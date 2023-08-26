### Compile & Run

Install the ef tool
```powershell
dotnet tool install --global dotnet-ef
```

Apply migrations
```powershell
dotnet ef database update
```

Build the project
```powershell
dotnet restore .
```

Enable secret manager
```powershell
dotnet user-secrets init
```

Self Signed Certification
```powershell
dotnet dev-certs https --trust
```