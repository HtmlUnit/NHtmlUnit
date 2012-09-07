@echo off
: This file makes a new version of HtmlUnit.dll from the original HtmlUnit JAR files.

: The version should be set to the same as that of the Java version of HtmlUnit
set VERSION=2.10.0.0

echo Please be patient while compiling HtmlUnit JAR files into HtmlUnit.dll.
echo There will be a lot of warnings; these can be safely ignored.
echo.
echo.

set JAVAC="C:\Program Files\Java\jdk1.7.0_03\bin\javac.exe"
set IKVM=..\..\packages\IKVM.NET.7.0.4335.1\lib
set IKVMC="%IKVM%\ikvmc.exe"
set IKVMSTUB="%IKVM%\ikvmstub.exe"

if exist %JAVAC% (
    if exist %IKVMC% (
        echo Generating mscorlib.jar
        echo.
        %IKVMSTUB% mscorlib

        echo Compiling AssemblyInfo.java
        echo.
        %JAVAC% -cp mscorlib.jar AssemblyInfo.java

        rem echo Compiling HtmlUnit.jar to HtmlUnit.dll [x64]
        rem echo.
        rem %IKVMC% -out:.\x64\HtmlUnit.dll -assembly:HtmlUnit -platform:x64 -version:%VERSION% -reference:mscorlib.dll assembly.class "lib\*.jar"

        rem echo Compiling HtmlUnit.jar to HtmlUnit.dll [x86]
        rem echo.
        rem %IKVMC% -out:.\x86\HtmlUnit.dll -assembly:HtmlUnit -platform:x86 -version:%VERSION% -reference:mscorlib.dll assembly.class "lib\*.jar"

        echo Compiling HtmlUnit.jar to HtmlUnit.dll [AnyCpu]
        echo.
        %IKVMC% -out:.\anycpu\HtmlUnit.dll -assembly:HtmlUnit -platform:anycpu -version:%VERSION% -reference:mscorlib.dll assembly.class "lib\*.jar"
    ) else (
        echo %IKVMC% not found.
    )
) else (
    echo %JAVAC% not found.
)

echo.
echo.
pause