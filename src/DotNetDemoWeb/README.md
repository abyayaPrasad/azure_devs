# DotNetDemoWeb

Simple ASP.NET Core demo app with:

- Static webpage at `/`
- Minimal API endpoint at `/api/health`

## Prerequisites

- .NET 8 SDK installed

Check:

```bash
dotnet --info
```

## Run the app

```bash
dotnet restore
dotnet run
```

Run these commands from this folder: `src/DotNetDemoWeb`.

## Test quickly

Open browser:

- `http://localhost:5000`
- or the URL shown in the terminal output

API test:

- `http://localhost:5000/api/health`

## Project files

- `Program.cs` - app startup and endpoint mapping
- `wwwroot/index.html` - demo page UI
- `DotNetDemoWeb.csproj` - project configuration
