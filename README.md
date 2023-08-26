### Requirements

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

Store Microsoft Client ID and Secrete
```bash
dotnet user-secrets set "Authentication:Microsoft:ClientId" "<client-id>"
dotnet user-secrets set "Authentication:Microsoft:ClientSecret" "<client-secret>"
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

### References

* [.Net Core Razor Pages](https://learn.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-7.0&tabs=visual-studio)
* [MSDocs - External Authentication Provider](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/social/?view=aspnetcore-7.0&tabs=visual-studio)
* [Microsoft SignIn Authentication](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/social/microsoft-logins?view=aspnetcore-7.0)