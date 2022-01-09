## Install csharp fixformat extension (vsix) in vs code

**Step 1**: Download this vsix file.

**Step 2**: Open the containing folder of the vsix file. Install it with the below command.

```bash
code --install-extension ./csharp-fixformat-0.0.84.vsix
```

**Step 3**: Open any `.cs` file, then click F1 to type "Format document with...", set "C# FixFormat" as default.

**Step 4**: You can use `Ctrl + K + F` to format C# code now.

### Code style of Visual Studio or Eclipse style about beginning bracket

<br>

**Visual Studio style**:

VSCode -> File -> Preferences -> Settings ->  <type `brace` ->  and **uncheck** CSharpFixFormat  -> Style -> Braces -> On Same Line 

<br>

**Eclipse (K & R) style**:

Check for `On Same Line` option
