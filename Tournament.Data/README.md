EF Migrations Cheat Sheet
-------------------------

### Set environment variables:
```sh
set ASPNETCORE_ENVIRONMENT=(Development|Staging|Production)
```

### Update/drop database using *Tournament.Api* as the startup project:
```sh
dotnet ef --startup-project ../Tournament.API/ database update
dotnet ef --startup-project ../Tournament.API/ database drop
```

### Add/remove migrations using *Tournament.Api* as the startup project:
```sh
dotnet ef --startup-project ../Tournament.API/ migrations add <name>
dotnet ef --startup-project ../Tournament.API/ migrations remove
```
