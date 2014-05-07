@echo off
echo Performing some hardcore file system nuking!
for /r /d %%x in (bin obj) do (
    echo "%%~fx" | find "tools">nul || rd /s /q "%%x" 2>nul
)