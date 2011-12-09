@echo off
: The version should be set to the same as that of the Java version of HtmlUnit
set VERSION=2.9.0.0

echo Please be patient while compiling HtmlUnit JAR files into HtmlUnit.dll.
echo There will be a lot of warnings; these can be safely ignored.
echo.
echo.

set JAVAC="C:\Program Files\Java\jdk1.7.0_01\bin\javac.exe"
set IKVM=..\IKVM\_bin
set IKVMC="%IKVM%\ikvmc.exe"
set IKVMSTUB="%IKVM%\ikvmstub.exe"

if exist %JAVAC% (
    if exist %IKVMC% (
        echo Generating mscorlib.jar ...
        echo.
        %IKVMSTUB% mscorlib

        echo Compiling AssemblyInfo.java ...
        echo.
        %JAVAC% -cp mscorlib.jar AssemblyInfo.java

        echo Compiling HtmlUnit.jar to HtmlUnit.dll (x64) ...
        echo.
        %IKVMC% -out:.\x64\HtmlUnit.dll -assembly:HtmlUnit -platform:x64 -version:%VERSION% -reference:mscorlib.dll assembly.class "..\..\tools\HtmlUnit\lib\*.jar"

        echo Compiling HtmlUnit.jar to HtmlUnit.dll (x86) ...
        echo.
        %IKVMC% -out:.\x86\HtmlUnit.dll -assembly:HtmlUnit -platform:x86 -version:%VERSION% -reference:mscorlib.dll assembly.class "..\..\tools\HtmlUnit\lib\*.jar"
    ) else (
        echo %IKVM% not found.
    )
) else (
    echo %JAVAC% not found.
)

echo.
echo.
pause