@echo off
 .nuget\nuget.exe pack NHtmlUnit.nuspec -Verbose -Symbols -Properties Configuration=Release

pause