### Compile & Run

Required ef tools
```bash
dotnet tool uninstall --global dotnet-aspnet-codegenerator
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet tool uninstall --global dotnet-ef
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

Apply migrations
```bash
dotnet ef database update
```

Build the project
```bash
dotnet restore .
```

Enable secret manager
```bash
dotnet user-secrets init
```

Self Signed Certification
```bash
dotnet dev-certs https --trust
```

Scaffold a model
```bash
dotnet aspnet-codegenerator razorpage -m ToDo -dc netcore_ms_auth.Data.ApplicationDbContext -udl -outDir Pages/ToDos
```

Generate Migrations
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```