<?xml version="1.0" encoding="utf-8"?>
<package xmlns="http://schemas.microsoft.com/packaging/2011/08/nuspec.xsd">
  <metadata>
    <id>Fluendo.GStreamer.Sharp</id>
    <version>{version}</version>
    <title>GStreamer bindings by Fluendo</title>
    <authors>Fluendo S.A.</authors>
    <owners>Fluendo S.A.</owners>
    <description>Unofficial GStreamer bindings maintained by Fluendo.</description>
    <tags>native graphics linux windows cross-platform</tags>
    <repository type="git" url="https://github.com/fluendo/fluendo-gstreamer-sharp.git" />
    <dependencies>
      <group targetFramework=".NETFramework4.7.2" />
      <group targetFramework=".NETCoreApp3.0" />
    </dependencies>
  </metadata>
   <files>
    <file src="nuget\*.dll" target="lib\net472" />
    <file src="nuget\*.dll.config" target="lib\net472" />
    <file src="nuget\*.dll" target="lib\netcoreapp3.0" />
  </files>
</package>