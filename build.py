import argparse
import glob
import hashlib
import platform
import shutil
import subprocess
import os
import shlex
import urllib.request
from collections import defaultdict
from pathlib import Path
from osxrelocator import OSXRelocator

GST_TEMPLATE = {
    'Windows': "gstreamer-1.0{}-msvc-x86_64-{}.msi",
    'Darwin': "gstreamer-1.0{}-{}-universal.pkg"
}
GST_URL_TEMPLATE = {
    'Windows': "https://gstreamer.freedesktop.org/data/pkg/windows/{}/msvc/",
    'Darwin': "https://gstreamer.freedesktop.org/data/pkg/osx/{}"
}


def download(url, output_file=None, md5=None):
    if output_file is None:
        output_file = url.split("/")[:-1]
    if os.path.exists(output_file):
        if md5 is not None:
            with open(output_file) as file_to_check:
                data = file_to_check.read()
                md5_returned = hashlib.md5(data).hexdigest()
                if md5_returned == md5:
                    print(f"File {output_file} already downloaded")
                    return
        else:
            print(f"File {output_file} already downloaded")
            return
    print(f"Downloading {url}")
    urllib.request.urlretrieve(url, output_file)
    print(f"Downloaded {output_file}")


def run(cmd, cwd=None, split=False):
    if split:
        if isinstance(cmd, str):
            cmd = shlex.split(cmd)
    if isinstance(cmd, list):
        print(f"Running command: {' '.join([str(x) for x in cmd])} in {cwd}")
    else:
        print(f"Running command: {cmd} in {cwd}")
    popen = subprocess.Popen(
        cmd, stdout=subprocess.PIPE, universal_newlines=True, cwd=cwd
    )
    lines = []
    for stdout_line in iter(popen.stdout.readline, ""):
        lines.append(stdout_line.split('\n')[0])
        print(stdout_line)
    popen.stdout.close()
    return_code = popen.wait()
    if return_code:
        raise subprocess.CalledProcessError(return_code, cmd)
    return lines


def replace(filepath, replacements):
    ''' Replaces keys in the 'replacements' dict with their values in file '''
    with open(filepath, 'r') as f:
        content = f.read()
    for k, v in replacements.items():
        content = content.replace(k, v)
    with open(filepath, 'w+') as f:
        f.write(content)


class Build:

    def __init__(self, platform: str, nuget_platform, source_dir: Path, build_dir: Path, cache_dir: Path = None):
        self.platform = platform
        self.nuget_platform = nuget_platform
        self.source_dir = source_dir
        self.build_dir = build_dir
        if cache_dir is None:
            cache_dir = self.build_dir / "cache"
        self.cache_dir = cache_dir
        self.gst_dir = self.cache_dir / "gstreamer"
        self.gst_build_dir = self.build_dir / "gst-build"
        self.prefix = self.build_dir / 'prefix'
        self.cache_dir.mkdir(parents=True, exist_ok=True)
        self.nuget_cmd = [self.cache_dir / "nuget.exe"]
        self._set_gst_version()
        self._set_nuget_version()
        self.nuget_dir = self.build_dir / "nuget"
        self.nuget_dir.mkdir(parents=True, exist_ok=True)

    def install_deps(self):
        run(["pip3", "install", "meson", "ninja"])
        download("https://dist.nuget.org/win-x86-commandline/latest/nuget.exe",
                 self.cache_dir / "nuget.exe")

    def install_gst_pkg(self):
        filename = GST_TEMPLATE[self.platform].format("", self.gst_version)
        filename_devel = GST_TEMPLATE[self.platform].format(
            "-devel", self.gst_version)
        url = f"{GST_URL_TEMPLATE[self.platform].format(self.gst_version)}/{filename}"
        url_devel = f"{GST_URL_TEMPLATE[self.platform].format(self.gst_version)}/{filename_devel}"
        download(url, self.cache_dir / filename)
        download(url_devel, self.cache_dir / filename_devel)
        self._install_package(self.cache_dir / GST_TEMPLATE[self.platform].format("", self.gst_version),
                              self.build_dir / "gst_install.log")
        self._install_package(self.cache_dir / GST_TEMPLATE[self.platform].format("-devel", self.gst_version),
                              self.build_dir / "gst_devel_install.log")

    def clone_gst(self):
        if not self.gst_dir.exists():
            run(["git", "clone", "https://github.com/fluendo/gstreamer.git", self.gst_dir])
        else:
            run(["git", "fetch"], self.gst_dir)
        run(["git", "reset", "--hard", "origin/dragonfly/1.20"], self.gst_dir)

    def configure_gst(self):
        cmd = ["meson", "setup", ".", self.gst_dir.as_posix(),
               "--wrap-mode=nofallback",
               f"--prefix={self.prefix.as_posix()}",
               "-Dauto_features=disabled",
               "-Dbase=disabled",
               "-Dgood=disabled",
               "-Dbad=enabled",
               "-Dgst-plugins-bad:mpegtsdemux=enabled"]
        if self.gst_build_dir.exists():
            shutil.rmtree(self.gst_build_dir)
        self.gst_build_dir.mkdir(parents=True)
        run(cmd, self.gst_build_dir)

    def build_gst(self):
        run(f"ninja", self.gst_build_dir)

    def build_gst_sharp(self):
        run("dotnet build GStreamer.Sharp/GStreamer.Sharp.sln -c Release ",
            cwd=self.source_dir, split=True)

    def install_gst(self):
        pass

    def install_gst_sharp_from_gstreamer(self):
        subprojects = self.gst_build_dir / "subprojects"

        gtk_sharp_src = subprojects / "gtk-sharp" / "Source"

        shutil.copy(gtk_sharp_src / "gio" / "gio-sharp.dll", self.nuget_dir)
        shutil.copy(gtk_sharp_src / "glib" / "glib-sharp.dll", self.nuget_dir)
        shutil.copy(subprojects / "gstreamer-sharp" /
                    "sources" / "gstreamer-sharp.dll", self.nuget_dir)
        shutil.copy(subprojects / "gstreamer-sharp" / "ges" /
                    "gst-editing-services-sharp.dll", self.nuget_dir)

    def create_nuget_package(self):
        replacements = {'{version}': self.nuget_version,
                        '{platform}': self.nuget_platform}

        shutil.copy(self.source_dir / "fluendo-gstreamer-sharp.nuspec.tpl",
                    self.build_dir / "fluendo-gstreamer-sharp.nuspec")
        replace(self.build_dir / "fluendo-gstreamer-sharp.nuspec", replacements)
        shutil.copy(self.source_dir / "fluendo-gstreamer-sharp-native.nuspec.tpl",
                    self.build_dir / f"fluendo-gstreamer-sharp-{self.nuget_platform}.nuspec")
        replace(self.build_dir /
                f"fluendo-gstreamer-sharp-{self.nuget_platform}.nuspec", replacements)
        shutil.copy(self.source_dir / "Fluendo.GStreamer.Sharp.native.targets",
                    self.nuget_dir / f"Fluendo.GStreamer.Sharp.{self.nuget_platform}.targets")

        run(self.nuget_cmd + ["pack", "fluendo-gstreamer-sharp.nuspec",
                              "-Verbosity", "detailed"], self.build_dir)
        run(self.nuget_cmd + ["pack", f"fluendo-gstreamer-sharp-{self.nuget_platform}.nuspec",
                              "-Verbosity", "detailed"], self.build_dir)

    def _install_package(self, path, log_file):
        raise NotImplemented()

    def _push_nuget(self, name, version):
        path = self.build_dir / f"{name}.{version}.nupkg"
        run(["dotnet", "nuget", "push", path,
            "--source", "https://nuget.pkg.github.com/fluendo/index.json",
             "--api-key", os.environ["GITHUB_TOKEN"]])

    def _set_gst_version(self):
        self.gst_version = os.environ.get("GITVERSION_MAJORMINORPATCH", None)
        if self.gst_version is None:
            self.gst_version = run(
                ["dotnet-gitversion", "/showvariable", "MajorMinorPatch"])[0]

    def _set_nuget_version(self):
        self.nuget_version = os.environ.get("GITVERSION_FULLSEMVER", None)
        if self.nuget_version is None:
            self.nuget_version = run(
                ["dotnet-gitversion", "/showvariable", "FullSemVer"])[0]

    def all_deps(self):
        self.install_deps()
        self.install_gst_pkg()
        self.clone_gst()
        self.configure_gst()
        self.build_gst()
        self.build_gst_sharp()
        self.install_gst()
        self.create_nuget_package()


class BuildMacOS(Build):

    def __init__(self, source_dir: Path, build_dir: Path, cache_dir: Path = None):
        super().__init__('Darwin', 'osx-x64', source_dir, build_dir, cache_dir)
        self.nuget_cmd = ["mono", self.cache_dir / "nuget.exe"]

    def configure_gst(self):
        gst_install_dir = self._get_gst_install_dir()
        os.environ["PKG_CONFIG"] = str(
            (gst_install_dir / "bin" / "pkg-config").absolute())
        os.environ["PKG_CONFIG_LIBDIR"] = str(
            (gst_install_dir / "lib" / "pkgconfig").absolute())
        super().configure_gst()

    def install_gst(self):
        super().install_gst()
        gst_native = self.nuget_dir / "runtimes" / self.nuget_platform / "native"
        gst_native_scanner_dir = self.nuget_dir / "runtimes" / \
            self.nuget_platform / "native" / "libexec" / "gstreamer-1.0"
        gst_native_scanner_dir.mkdir(parents=True, exist_ok=True)
        gst_native_plugins = gst_native / "lib" / "gstreamer-1.0"
        gst_native_plugins.mkdir(parents=True, exist_ok=True)
        subprojects = self.gst_build_dir / "subprojects"

        shutil.copy(self.source_dir / "GStreamer.Sharp" / "bin" /
                    "Release" / "netstandard2.0" / "GStreamer.Sharp.dll",
                    self.nuget_dir)
        shutil.copy(self.source_dir / "GStreamer.Sharp" / "bin" /
                    "Release" / "netstandard2.0" / "GStreamer.Sharp.dll.config",
                    self.nuget_dir)

        # GStreamer
        gst_install_dir = self._get_gst_install_dir()
        lib_files = glob.glob(f'{gst_install_dir / "lib"}/*.dylib')

        # The installer does not respect symlinks, copy only the real
        # library:
        # Pick libgobject-2.0.0.dylib and leave libgobject-2.0.dylib
        files = {}
        for f in lib_files:
            if Path(f).is_symlink():
                continue
            name = os.path.basename(f)
            key = name.split('.')[0]
            # Take the path with the longest path libgobject-2.0.0.dylib vs libgobject-2.0.dylib
            if not key in files or len(files[key]) < len(f):
                files[key] = f
        for f in files.values():
            self.copy(f, gst_native)

        for file in glob.glob(f'{gst_install_dir / "lib" / "gstreamer-1.0"}/*.dylib'):
            if not Path(file).is_symlink():
                self.copy(file, gst_native_plugins)
        self.copy(gst_install_dir / "libexec" / "gstreamer-1.0" /
                  "gst-plugin-scanner", gst_native_scanner_dir)

        # Custom GStreamer
        shutil.copy(subprojects / "gst-plugins-bad" / "gst-libs" / "gst" / "mpegts" / "libgstmpegts-1.0.0.dylib",
                    gst_native)
        shutil.copy(subprojects / "gst-plugins-bad" / "gst" / "mpegtsdemux" / "libgstmpegtsdemux.dylib",
                    gst_native_plugins)

        # There can several rpaths with the prefix dir, remove them all
        while True:
            try:
                run(["install_name_tool", "-delete_rpath", "/Library/Frameworks/GStreamer.framework/Versions/Current/lib",
                    gst_native / "libgstmpegts-1.0.0.dylib"])
            except:
                break

        run(["rm", "-f", "libavcodec.58.dylib", "libavformat.58.dylib",
            "libavfilter.7.dylib", "libavutil.56.dylib"], gst_native)
        run(["ln", "-s", "libavcodec.58.134.100.dylib",
            "libavcodec.58.dylib"], gst_native)
        run(["ln", "-s", "libavformat.58.76.100.dylib",
            "libavformat.58.dylib"], gst_native)
        run(["ln", "-s", "libavfilter.7.110.100.dylib",
            "libavfilter.7.dylib"], gst_native)
        run(["ln", "-s", "libavutil.56.70.100.dylib",
            "libavutil.56.dylib"], gst_native)

        relocator = OSXRelocator(False)
        strip = os.environ.get("STRIP", "strip")
        files_to_post_process = glob.glob(f"{gst_native}/*dylib") + \
            glob.glob(f"{gst_native_plugins}/*dylib") + \
            [gst_native_scanner_dir / "gst-plugin-scanner"]
        for f in files_to_post_process:
            relocator.change_libs_path(f)
            run([strip, "-SX", f])

    def push_nuget_package(self):
        # From macOS we only push the native binaries
        self._push_nuget(
            f"Fluendo.GStreamer.Sharp.{self.nuget_platform}", self.nuget_version)

    def copy(self, src, dst_dir):
        filename = os.path.split(src)[1]
        dst = dst_dir / filename
        run(["lipo", src, "-thin", "x86_64", "-output", dst])

    def _get_gst_install_dir(self):
        return Path("/Library/Frameworks/GStreamer.framework/Versions/Current/")

    def _install_package(self, path, log_file):
        run(["sudo", "installer", "-pkg", path, "-target", "/"])


class BuildWin64(Build):

    def __init__(self, source_dir: Path, build_dir: Path, cache_dir: Path = None):
        super().__init__('Windows', 'win-x64', source_dir, build_dir, cache_dir)

    def install_deps(self):
        super().install_deps()
        Path("C:/Strawberry/c/bin/xsltproc.EXE").unlink()
        download("https://dist.nuget.org/win-x86-commandline/latest/nuget.exe",
                 self.cache_dir / "nuget.exe")

    def configure_gst(self):
        gst_install_dir = self._get_gst_install_dir()
        os.environ["PKG_CONFIG"] = str(
            (gst_install_dir / "bin" / "pkg-config.exe").absolute())
        os.environ["PKG_CONFIG_LIBDIR"] = str(
            (gst_install_dir / "lib" / "pkgconfig").absolute())
        os.environ["PATH"] = f'{str(gst_install_dir / "bin")};{os.environ["PATH"]}'

        super().configure_gst()

    def install_gst(self):
        super().install_gst()

        gst_native = self.nuget_dir / "runtimes" / "win-x64" / "native"
        gst_native_plugins = gst_native / "lib" / "gstreamer-1.0"
        gst_native_plugins.mkdir(parents=True, exist_ok=True)
        subprojects = self.gst_build_dir / "subprojects"

        shutil.copy(self.source_dir / "GStreamer.Sharp" / "bin" / "x64" /
                    "Release" / "netstandard2.0" / "GStreamer.Sharp.dll",
                    self.nuget_dir)
        shutil.copy(self.source_dir / "GStreamer.Sharp" / "bin" / "x64" /
                    "Release" / "netstandard2.0" / "GStreamer.Sharp.dll.config",
                    self.nuget_dir)

        # GStreamer
        gst_install_dir = self._get_gst_install_dir()
        for file in glob.glob(f'{gst_install_dir / "bin"}/*.dll'):
            shutil.copy(file, gst_native)
        for file in glob.glob(f'{gst_install_dir / "lib" / "gstreamer-1.0"}/*.dll'):
            shutil.copy(file, gst_native_plugins)
        shutil.copy(gst_install_dir / "libexec" / "gstreamer-1.0" /
                    "gst-plugin-scanner.exe", gst_native)

        # Custom GStreamer
        shutil.copy(subprojects / "gst-plugins-bad" / "gst-libs" / "gst" / "mpegts" / "gstmpegts-1.0-0.dll",
                    gst_native)
        shutil.copy(subprojects / "gst-plugins-bad" / "gst" / "mpegtsdemux" / "gstmpegtsdemux.dll",
                    gst_native_plugins)

        # Strip GCC shared libraries
        strip = os.environ.get("STRIP", "strip.exe")
        run(f"{strip} -s {gst_native / 'avcodec-58.dll'}")
        run(f"{strip} -s {gst_native / 'avformat-58.dll'}")
        run(f"{strip} -s {gst_native / 'avfilter-7.dll'}")
        run(f"{strip} -s {gst_native / 'avutil-56.dll'}")
        for f in glob.glob(f"{gst_native}/lib*dll"):
            run(f"{strip} -s {f}")

    def push_nuget_package(self):
        self._push_nuget(
            f"Fluendo.GStreamer.Sharp", self.nuget_version)
        self._push_nuget(
            f"Fluendo.GStreamer.Sharp.{self.nuget_platform}", self.nuget_version)

    def all_deps(self):
        self.install_intel_onevpl()
        super().all_deps()

    def _get_gst_install_dir(self):
        import winreg
        key = winreg.OpenKey(winreg.HKEY_LOCAL_MACHINE,
                             r"SOFTWARE\WOW6432Node\GStreamer1.0\x86_64",
                             0, winreg.KEY_ALL_ACCESS)
        return Path(winreg.QueryValueEx(key, 'InstallDir')[0]) / "1.0" / "msvc_x86_64"

    def _install_package(self, path, log_file):
        run(f"msiexec /i {path} /quiet /l* {log_file} /norestart ADDLOCAL=All")


if __name__ == '__main__':
    parser = argparse.ArgumentParser()
    parser.add_argument('build_rule', type=str,
                        help='The name of the build rule to call', default='all')
    parser.add_argument('-c', '--cache-dir', type=str,
                        help='Cache directory to use')
    parser.add_argument('-b', '--build-dir', type=str,
                        help='Build directory to use')
    args = parser.parse_args()
    root_dir = Path(os.path.dirname(__file__))
    if args.build_dir is None:
        build_dir = root_dir / "build"
    else:
        build_dir = Path(os.path.expanduser(args.build_dir))
    build_dir.mkdir(parents=True, exist_ok=True)
    os.chdir(build_dir)
    if args.cache_dir is None:
        cache_dir = build_dir / "cache"
    else:
        cache_dir = Path(os.path.expanduser(args.cache_dir))

    plat = platform.system()
    if plat == 'Windows':
        build_cls = BuildWin64
    elif plat == 'Darwin':
        build_cls = BuildMacOS
    else:
        print("OS not supported")
        exit(-1)
    build = build_cls(root_dir, build_dir, cache_dir)
    print(f"Using cache: {str(cache_dir.absolute())}")
    getattr(build, args.build_rule)()
