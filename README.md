# Multi-targeting issues

This is the showcase of an issue with the restore system of nuget.
For some reasons, when a `PackageId` is defined, restore will break and use the dependency with the latest version, 
not taking into account the conditional use nor the supported TargetFramework for said dependency.

## Workarounds

Multiple workaround exist, including on currently used in `Directory.Build.Props`.

## Main Workaround

This solution involve the use of a target within a range of time to unset the `PackageId` before the restore, effectively solving the issue.

## Other Workarounds

1. You could also package the dependency, build a local nuget field for the repo specifically and then use those packages, but this solution is overkill when simpler workarounds exist.

2. You can create a separate folder & project for each versions of the dependency, include the source of the main project in that folder, and then use that as a dependency.

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>
    <Nullable>enable</Nullable>
    <NoWarn>NETSDK1138</NoWarn>
    <RootNamespace>Some.Dependency</RootNamespace>
    <AssemblyName>Some.Dependency</AssemblyName>
  </PropertyGroup>

  <ItemGroup>
    <Compile Include="../Some.Dependency-0.6.x/**/*.cs" CopyToOutputDirectory="Never" />

    <Compile Remove="../Some.Dependency-0.6.x/obj/**/*.cs" />
    <Compile Remove="../Some.Dependency-0.6.x/bin/**/*.cs" />
  </ItemGroup>

</Project>
```