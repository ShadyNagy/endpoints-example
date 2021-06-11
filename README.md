# endpoints-example
Ardalis endpoint example


### Running Migrations

**Migrations should be run from the `src/Ardalis.Endpoints.Examples folder`**

#### Create Migrations

If you need to create a migration, here are sample scripts to work from.

From the Ardalis.Endpoints.Examples directory; 

```
dotnet ef migrations add InitialModel --context appdbcontext -p ../Ardalis.Endpoints.Infrastructure/Ardalis.Endpoints.Infrastructure.csproj -s Ardalis.Endpoints.Examples.csproj -o Data/Migrations
```

#### Run Migrations Locally for Development

Before running the first time, you'll need to run migrations for the app dbcontext.

From the Ardalis.Endpoints.Examples directory:

```powershell
dotnet ef database update -c appdbcontext -p ../Ardalis.Endpoints.Infrastructure/Ardalis.Endpoints.Infrastructure.csproj -s Ardalis.Endpoints.Examples.csproj
```


