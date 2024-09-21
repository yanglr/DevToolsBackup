## Quick way to create a new C# project

用 cmd 快速创建 C# 项目的步骤:



```shell
mkdir Chap8-OrganizingData
cd Chap8-OrganizingData

dotnet new console -n Tip1-SelfEncapsulateField --framework "net6.0" --use-program-main
```



其中参数 `--use-program-main` 的作用是禁用Top level statement (--no-top-level-statements)



参考:

https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new



Top level templates#use the old program style - Microsoft Learn

<https://learn.microsoft.com/en-us/dotnet/core/tutorials/top-level-templates#use-the-old-program-style>







