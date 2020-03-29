
### Running in Visual Studio

- Set Startup projects:
  - Skoruba.IdentityServer4.Admin
  - Skoruba.IdentityServer4.STS.Identity

## Configuration of Administration for Deployment

- [Configuration of Admin for deploy on Azure](docs/Configure-Azure-Deploy.md)
- [Configuration of Admin on Ubuntu with PostgreSQL database](docs/Configure-Ubuntu-PostgreSQL-Tutorial.md)

## EF Core & Data Access

- The solution uses these `DbContexts`:

  - `AdminIdentityDbContext`: for Asp.Net Core Identity
  - `AdminLogDbContext`: for logging
  - `IdentityServerConfigurationDbContext`: for IdentityServer configuration store
  - `IdentityServerPersistedGrantDbContext`: for IdentityServer operational store

- Run entity framework migrations:

### Visual Studio command line (Nuget package manager):

#### Migrations for Asp.Net Core Identity DbContext:

```powershell
Add-Migration AspNetIdentityDbInit -context AdminIdentityDbContext -output Data/Migrations/Identity
Update-Database -context AdminIdentityDbContext
```

#### Migrations for Logging DbContext:

```powershell
Add-Migration LoggingDbInit -context AdminLogDbContext -output Data/Migrations/Logging
Update-Database -context AdminLogDbContext
```

#### Migrations for IdentityServer configuration DbContext:

```powershell
Add-Migration IdentityServerConfigurationDbInit -context IdentityServerConfigurationDbContext -output Data/Migrations/IdentityServerConfiguration
Update-Database -context IdentityServerConfigurationDbContext
```

#### Migrations for IdentityServer persisted grants DbContext:

```powershell
Add-Migration IdentityServerPersistedGrantsDbInit -context IdentityServerPersistedGrantDbContext -output Data/Migrations/IdentityServerGrants
Update-Database -context IdentityServerPersistedGrantDbContext
```

### Or via `dotnet CLI`:

#### Migrations for Asp.Net Core Identity DbContext:

```powershell
dotnet ef migrations add AspNetIdentityDbInit -c AdminIdentityDbContext -o Data/Migrations/Identity
dotnet ef database update -c AdminIdentityDbContext
```

#### Migrations for Logging DbContext:

```powershell
dotnet ef migrations add LoggingDbInit -c AdminLogDbContext -o Data/Migrations/Logging
dotnet ef database update -c AdminLogDbContext
```

#### Migrations for IdentityServer configuration DbContext:

```powershell
dotnet ef migrations add IdentityServerConfigurationDbInit -c IdentityServerConfigurationDbContext -o Data/Migrations/IdentityServerConfiguration
dotnet ef database update -c IdentityServerConfigurationDbContext
```

#### Migrations for IdentityServer persisted grants DbContext:

```powershell
dotnet ef migrations add IdentityServerPersistedGrantsDbInit -c IdentityServerPersistedGrantDbContext -o Data/Migrations/IdentityServerGrants
dotnet ef database update -c IdentityServerPersistedGrantDbContext
```

## Authentication and Authorization

- Change the specific URLs and names for the IdentityServer and Authentication settings in `Constants/AuthenticationConsts` or `appsettings.json`
- `Constants/AuthorizationConsts.cs` contains configuration of constants connected with authorization - definition of the default name of admin policy
- In the controllers is used the policy which name is stored in - `AuthorizationConsts.AdministrationPolicy`. In the policy - `AuthorizationConsts.AdministrationPolicy` is defined required role stored in - `AuthorizationConsts.AdministrationRole`.
- With the default configuration, it is necessary to configure and run instance of IdentityServer4. It is possible to use initial migration for creating the client as it mentioned above

### Login Configuration

- In `Skoruba.IdentityServer4.STS.Identity` - in `appsettings.json` is possible to specify which column will be used for login (`Username` or `Email`):

```
  "LoginConfiguration": {
    "ResolutionPolicy": "Username"
  }
```

or using `Email`:

```
  "LoginConfiguration": {
    "ResolutionPolicy": "Email"
  }
```

### Register Configuration

- In `Skoruba.IdentityServer4.STS.Identity` - in `appsettings.json` is possible to disable user registration (`default: true`):

```
 "RegisterConfiguration": {
    "Enabled": false
  }
```

## Localizations - labels, messages

- All labels and messages are stored in the resources `.resx` - locatated in `/Resources`

  - Client label descriptions from - http://docs.identityserver.io/en/latest/reference/client.html
  - Api Resource label descriptions from - http://docs.identityserver.io/en/latest/reference/api_resource.html
  - Identity Resource label descriptions from - http://docs.identityserver.io/en/latest/reference/identity_resource.html

## Tests

- The solution contains unit and integration tests.
- **Stage environment is used for integration tests**:

  - `DbContext` contains setup for InMemory database
  - `Authentication` is setup for `CookieAuthentication` - with fake login url only for testing purpose
  - `AuthenticatedTestRequestMiddleware` - middleware for testing of authentication.

- If you want to use `Stage environment` for deploying - it is necessary to change these settings in `StartupHelpers.cs`.

