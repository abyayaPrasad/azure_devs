# Azure Devs - DotNet Demo

This repository now contains a demo ASP.NET Core web application you can run locally.

## Repository structure

```text
azure_devs/
├─ README.md
└─ src/
   └─ DotNetDemoWeb/
      ├─ DotNetDemoWeb.csproj
      ├─ Program.cs
      └─ wwwroot/
         └─ index.html
      ├─ MyFunctionApp/
          ├─ MyFunctionApp.csproj
          ├─ Program.cs
          ├─ host.json
          ├─ local.settings.json
          └─ Functions/
               └─ HttpTrigger.cs
      └─ MyFunctionApp.Tests/
          ├─ MyFunctionApp.Tests.csproj
          └─ UnitTest1.cs
```

## What needs to be installed

- .NET 8 SDK
  - Download: [https://dotnet.microsoft.com/en-us/download/dotnet/8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- (Optional) Visual Studio Code or Visual Studio 2022

To confirm installation:

```bash
dotnet --version
```

## How to run locally

From repository root:

```bash
cd src/DotNetDemoWeb
dotnet restore
dotnet run
```

Then open the URL printed in the terminal (usually `http://localhost:5000` or `https://localhost:7000`).

## Demo endpoints

- Web page: `/`
- Health API: `/api/health`

## Notes

- The app serves a static demo page from `wwwroot/index.html`.
- Minimal API endpoint is defined in `Program.cs`.

## .NET + Azure Functions repo scaffold

This repository contains an opinionated scaffold for developing Azure Functions using .NET (isolated worker model, .NET 7). It includes a sample function project, a test project, CI workflow, and common config files.

Layout

- `src/` - application source code
   - `MyFunctionApp/` - sample Azure Functions app
      - `Program.cs` - function host bootstrap
      - `host.json` - host configuration
      - `local.settings.json` - local development settings (do not commit secrets)
      - `Functions/HttpTrigger.cs` - example HTTP-trigger function
      - `MyFunctionApp.csproj` - function project
- `tests/` - unit tests
   - `MyFunctionApp.Tests/` - sample xUnit test project
- `.github/workflows/ci.yml` - GitHub Actions CI for build & test
- `.gitignore` - ignores build artifacts and local secrets

Quick start (locally)

1. Install .NET 7 SDK: https://dotnet.microsoft.com
2. From repo root:

```powershell
dotnet restore
dotnet build
dotnet test
```

3. To run the Function locally use the Azure Functions Core Tools (optional):

```powershell
npm i -g azure-functions-core-tools@4 --unsafe-perm true
func start --project src/MyFunctionApp
```

Notes

- `local.settings.json` should not be committed; `.gitignore` includes it by default. Replace values with your real secrets using your preferred secret store in CI/CD.
- The sample uses the isolated worker model for Azure Functions. If you prefer the in-process model, the project files will differ.
