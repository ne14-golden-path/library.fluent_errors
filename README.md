## FluentErrors

``` powershell
# Restore tools
dotnet tool restore

# Run unit tests (multiple test projects, no threshold)
gci **/TestResults/ | ri -r; dotnet test -c Release -s .runsettings; dotnet reportgenerator -targetdir:coveragereport -reports:**/coverage.cobertura.xml -reporttypes:"html;jsonsummary"; start coveragereport/index.html;

# Run mutation tests and show report
gci **/StrykerOutput/ | ri -r; dotnet stryker -o;
```

## Original Project Setup
```powershell
# check dotnet versions
dotnet --list-sdks

# set dotnet version (remember to tweak pre-release, and newer versions)
dotnet new globaljson --sdk-version 8.0.100

# add a tool manifest
dotnet new tool-manifest

# add some tools
dotnet tool install dotnet-reportgenerator-globaltool
dotnet tool install dotnet-stryker
```

# GitHub Account Setup
  1. Create a new PAT (1 per account): `Account > Settings > Developer Settings > Personal Access Tokens`
  1. Provide read:packages to it
  1. Add nuget feed in your local %APPDATA%/NuGet/NuGet.Config

# GitHub Repo Setup
  1. Generate a new SSH Key Pair
  1. Add a Deploy Key called `COMMIT_KEY_PUB` containing the public part of the SSH key (do give write access)
  1. Add a Secret called `COMMIT_KEY` containing the private part of the SSH key
  1. Add a Secret called `READ_REPO_PACKAGES` containing the *packages:read* central PAT Token
  1. Ensure csproj in your package project has correct <VersionPrefix> and <RepoUrlStyle> tags
  1. Ensure repo workflows have read and write permissions: `Repo > Settings > Actions > Workflow permissions`