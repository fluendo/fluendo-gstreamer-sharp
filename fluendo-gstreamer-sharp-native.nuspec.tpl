<?xml version="1.0" encoding="utf-8"?>
<package xmlns="http://schemas.microsoft.com/packaging/2011/08/nuspec.xsd">
  <metadata>
    <id>Fluendo.GStreamer.Sharp.{platform}</id>
    <version>{version}</version>
    <title>GStreamer native libraries by Fluendo</title>
    <authors>Fluendo S.A.</authors>
    <owners>Fluendo S.A.</owners>
    <description>Unnoficial GStreamer native libraries and dependencies maintained by Fluendo.</description>
    <tags>native graphics linux windows</tags>
    <repository type="git" url="https://github.com/fluendo/fluendo-gstreamer-sharp.git" />
  </metadata>
   <files>
    <file src="nuget\runtimes\{platform}\native\**" target="runtimes\{platform}\native" />
  </files>
</package>