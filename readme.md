## Comandos Utéis

### Criação de Migrations
``` bash
dotnet ef migrations add CreatingModels   --project Psycheflow.Api.Persistence --startup-project Psycheflow.Api/Psycheflow.Api.csproj
```

### Rodar as migrations
```bash
dotnet ef database update --project Psycheflow.Api.Persistence --startup-project Psycheflow.Api/Psycheflow.Api.csproj
```