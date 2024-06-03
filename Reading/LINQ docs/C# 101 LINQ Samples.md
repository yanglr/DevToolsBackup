## C# 101 LINQ Samples

**How to use 101 C# LINQ Samples?**

https://github.com/dotnet/try-samples



The enviornment:

**OS**: Win 11

**.NET SDKs**: .NET Core 3.0 SDK, .NET Core 3.1 SDK, .NET 6.0 SDK, .NET 8.0 SDK installed.

## 1.Make sure you installed lastest version of "dotnet try" tool.

If you install it with the command "dotnet tool install -g dotnet-try", you need unistall it first with:

```shell
dotnet tool uninstall -g dotnet-try
```

If you install it with the command "dotnet tool install -g Microsoft.dotnet-try", you need unistall it first with:
```shell
dotnet tool uninstall -g Microsoft.dotnet-try
```

Then install the latest verion of "dotnet try" with below command:
```shell
dotnet tool install -g --add-source "https://pkgs.dev.azure.com/dnceng/public/_packaging/dotnet-tools/nuget/v3/index.json" Microsoft.dotnet-try
```

In Windows, recommand to run above commands in "cmd" with admin permission.

## 2.Make sure you installed .NET 3.0 and .NET 3.1 SDKs
You can run below command to check:
```shell
dotnet --list-sdks
```

If you did not install them, download from below links and install them.

https://dotnet.microsoft.com/en-us/download/dotnet/3.0
https://dotnet.microsoft.com/en-us/download/dotnet/3.1

**Note**: .NET core 3.1 SDK's version is "3.1.416" so far.

## 3.Clone code with below command using git shell

```shell
git clone https://github.com/dotnet/try-samples
```

## 4.Create global.json at the root of the folder "try-samples":

The content is below:

```json
{
  "sdk": {
    "version": "3.1.416"
  }
}
```

**Note**: the version "3.1.416" here should be the same as in step 2.

## 5.Try to compile it with "dotnet try verify" command

```shell
cd try-samples/
dotnet try verify
```

If no exceptions happened, jump to next step below.
Else try to remove references to the package 'System.CommandLine.Experimental' from all of the .csproj files.

## 6.Run "dotnet try" command to open the web in browser:

```shell
dotnet try ".\101-linq-samples"
```

## 7.Try the examples from Web.


May it be helpful for you.

---

**References:**

https://github.com/dotnet/try/blob/main/DotNetTryLocal.md

https://github.com/dotnet/try/issues/938#issuecomment-1023604536

This anwer first published in:
https://stackoverflow.com/a/78534041/6075331
