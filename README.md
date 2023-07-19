# C_sharp

### Installing the .NET 6 SDK

https://dotnet.microsoft.com/en-us/download/dotnet/6.0
```md
dotnet --version
````

### Installing Tools: dotnet-ef
**run it once to make it global**
```md
dotnet tool install --global dotnet-ef
````

### Installing the "C# for Visual Studio Code" plugin from OmniSharp


### Starting up a new Console App
```md
mkdir FirstCSharp
cd FirstCSharp
dotnet new console
````
**One line (-o creates the folder for you if the folder name does not already exist):**
```md
dotnet new console -o FirstCSharp
````

### run

```md
dotnet run
````

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
````
