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