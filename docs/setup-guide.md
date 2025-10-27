# NexOps Setup Guide

This guide will help you set up **NexOps** locally using .NET 9 and PostgresSQL

---

** Prerequisites

| Tool | Version | Download |
|------|---------|----------|
| .NET SDK | 9.0+ | [dotnet.microsoft.com/download](https://dotnet.microsoft.com/download) |
| PostgresSQL | 17+ | [postgresql.org](https://www.postgresql.org/download) |
| Visual Studio / VS Code | Latest | [visualstudio.microsoft.com](https://visualstudio.microsoft.com/) |
| Git | Latest | [git-scm.com](https://git-scm.com/) |

---

## Steps 

## 1. Clone the project

```bash

git clone https://github.com//eringz/NexOps.git
cd NexOps

```

## 2. Create the database 

```bash

CREATE DATABASE nexops_db;

```

## 3. Update Connection string

In appsetting.json:

```bash

"ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=nexops_db;Username=postgres;Password=yourpassword"
}

```

## 4. Run EF migrations

```bash

dotnet ef database update --project NexOps.Core

```

## 5. Run both projects 

```bash

dotnet watch --project NexOps.Core run
dotnet watch --project NexOps.UI run

```
---

Visit https://localhost:5001

---

