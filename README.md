# SpecFlow running in the new VS2017 csproj Project System
This is a sample project using the MS Build generation feature of SpecFlow to make SpecFlow work with the new project system.

## Files of Interest
- /build/specflow.props
- /build/specflow.targets
- /SpecFlow.ProjectSystem.Tests/SpecFlow.ProjectSystem.Tests.csproj

## Benefits
- Csproj file is no longer cluttered with feature files and step definition files, making merging easier.
- Uses `PackageReference` instead of `packages.config` which in turn uses the global nuget cache directory so that there is no packages directory in your project.
- Uses MS Build generation so that `.feature.cs` files can be excluded from source control.

## Known Limitations
- Only works with generators that are built into SpecFlow (such as MS Test). This is due to the SpecFlow library not supporting the folder structure of the global nuget folder.
- Some of the SpecFlow tooling doesn't work (intellisense and go to definition).
- Does not work with .NET Core.
- You must maintain the specflow verion you are using. By default, it will use 2.1.0 which is configured in the specflow.props file. If you want to override the version, you use the property `SpecFlowVersion`.
- Adding `.feature` files works correctly, however adding SpecFlows `Step Definition` template file add the item to the csproj so it is recommended to add a standard class file and generate the steps using the feature file via `Right Click -> Generate Step Definitions`.
