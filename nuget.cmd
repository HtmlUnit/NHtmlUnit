@echo off
if "%1"=="pack" (
    .nuget\nuget.exe pack NHtmlUnit.nuspec -Verbosity detailed -Symbols -Properties Configuration=Release
    goto end
)

if "%1"=="push" (
    for %%x in (NHtmlUnit*.nupkg) do (
        echo "%%~fx" | find "symbols">nul || .nuget\nuget.exe push %%x -Verbosity detailed        
    )
    goto end
)

:fail
    echo.
    echo Invalid parameter '%1'. Usage:
    echo.
    echo     nuget [pack ^| push]
    echo.
    pause

:end