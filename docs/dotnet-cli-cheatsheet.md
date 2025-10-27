# .NET CLI Cheatsheet

Essential .NET commands for working with **NexOps**

---

## Project Management

```bash

dotnet new sln -n NexOps
dotnet new worker -n NexOps.Core
dotnet new blazorserver -n NexOps.UI
dotnet sln add NexOps.Core/NexOps.Core.csproj
dotnet sln add NexOps.UI/NexOps.UI.csproj

```

## Build and Run

```bash

dotnet restore
dotnet build
dotnet watch --project NexOps.UI run
dotnet watch --project NexOps.Core run

```

## Database

```bash
# Recommended: repo-local tool manifest (team/CI-friendly)
dotnet new tool-manifest
dotnet tool install --global dotnet-ef --version 9.0.0

# restore tools on a new machine / CLI
dotnet tool restore

# Ensure EF.Design package is in the Core project
dotnet add NexOps.Core package Microsoft.EntityFrameworkCore.Design

# Create and apply migrations (adjust project paths as needed)
dotnet ef migrations add Init --project NexOps.Core --startup-project
dotnet ef database update --project NexOps.Core

```

## Info

```bash

dotnet --info
dotnet --list-sdks
dotnet --version

```


