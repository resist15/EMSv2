# EMSv2

### - Add Entity Packages

> dotnet add package Microsoft.EntityFrameworkCore.SqlServer

> dotnet add package Microsoft.EntityFrameworkCore.Tools

### - Install `dotnet-ef` tool

> dotnet tool install --global dotnet-ef

### - Run DB Migrations

>dotnet ef migrations add InitialCreate

>dotnet ef database update