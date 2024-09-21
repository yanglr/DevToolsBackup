@echo off
setlocal enabledelayedexpansion

:: Prompt the user for the folder name the first time
echo Please enter the folder name:
set /p "folderName="

:: Check if the user wants to exit
if "!folderName!"=="" (
    echo Exiting...
    exit /b
)

:: Create the folder if it does not exist
if not exist "!folderName!" (
    mkdir "!folderName!"
    echo Folder "!folderName!" created.
) else (
    echo Folder "!folderName!" already exists.
)

echo.

:: Change to the folder
cd /d "!folderName!"

:loop
set "projectName="

:: Loop starts, only the project name is required each time
echo Please enter the project name (or press Enter to exit):
set /p "projectName="

:: Check if the user wants to exit
if "!projectName!"=="" (
    echo Exiting...
    goto end
)

:: Create the project
dotnet new console -n "!projectName!" --framework "net6.0" --use-program-main
echo Project "!projectName!" created.

:: Create another project
echo.
goto loop

:end
echo Exiting...
cd ..
endlocal