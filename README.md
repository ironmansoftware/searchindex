# Search Index Cmdlet Example

This repository is an example of a cmdlet library for the Windows Search Index. 

## Building

You can use .NET Core 3.0 or later to build this repository. 

```powershell
dotnet publish
```

## Usage

You can use this library by importing the `Microsoft.Search.Index.dll` and `searchindex.dll`.

```powershell
Import-Module .\Microsoft.Search.Index.dll
Import-Module .\searchindex.dll

Get-SearchIndexStatus
```
