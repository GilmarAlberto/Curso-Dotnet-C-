dotnet remove package Microsoft.EntityFrameworkCore
dotnet remove package Microsoft.EntityFrameworkCore.Design
dotnet remove package Microsoft.EntityFrameworkCore.Relational
dotnet remove package Microsoft.EntityFrameworkCore.Tools
dotnet remove package Pomelo.EntityFrameworkCore.MySql

dotnet add package Microsoft.EntityFrameworkCore --version 8.0.0
dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.0
dotnet add package Microsoft.EntityFrameworkCore.Relational --version 8.0.0
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.0
dotnet add package Pomelo.EntityFrameworkCore.MySql --version 8.0.0

dotnet restore
dotnet build
