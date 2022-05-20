# BasicDataStructures

A basic .NET Core console project for learning and exploring data structures.

## dotnet CLI

dotnet CLI used to create this project:

```ps1: In C:\src\github.com\ongzhixian\BasicDataStructures
dotnet new sln -n BasicDataStructures
dotnet new console -n BasicDataStructures.ConsoleApp
dotnet sln .\BasicDataStructures.sln add .\BasicDataStructures.ConsoleApp\

dotnet add .\BasicDataStructures.ConsoleApp\ package BenchmarkDotNet

```

## Other packages that we may want to include to expand on configuration options:
Microsoft.Extensions.Configuration
Microsoft.Extensions.Configuration.Json
Microsoft.Extensions.Configuration.UserSecrets
Microsoft.Extensions.Configuration.CommandLine
Microsoft.Extensions.Configuration.Binder
Microsoft.Extensions.Configuration.EnvironmentVariables 
