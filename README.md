# C_sharp

### Installing the .NET 6 SDK

https://dotnet.microsoft.com/en-us/download/dotnet/6.0

```md
dotnet --version
```

### Installing Tools: dotnet-ef

**run it once to make it global**
it is for Entity Framework Core Entity Framework and Connecting to MySQL

```md
dotnet tool install --global dotnet-ef

dotnet tool install --global dotnet-ef --version 8.\*
```

### Installing the "C# for Visual Studio Code" plugin from OmniSharp

### Starting up a new Console App

```md
mkdir FirstCSharp
cd FirstCSharp
dotnet new console
```

**One line (-o creates the folder for you if the folder name does not already exist):**

```md
dotnet new console -o FirstCSharp
```

### run

```md
dotnet run
```

### Program.cs File in Older Versions of .NET

```md
using System;

namespace FirstCSharp
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine("Hello, World!");
}
}
}
```

## Intro to ASP.NET Core

### blid web project

```md
dotnet new web --no-https -o ProjectName
```

#### run

```md
dotnet run
```

```md
dotnet watch run
```

### bulid mvc project

```md
dotnet new mvc --no-https -o ProjectName
```

### everything is up to date

```md
dotnet restore
```

### Head into your project and run these two commands from the terminal:
will be in `ProjectName.csproj` file
```md
dotnet add package Pomelo.EntityFrameworkCore.MySql --version 6.0.1
dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.3
```

 ### make migrations 
needed just ones for connected to DB
```md
dotnet ef migrations add FirstMigration
```
or
```md
dotnet ef migrations add FirstMigration -v
```

### push the changes for the database to sql
it can be reuse for the code 
```md
dotnet ef database update
```


