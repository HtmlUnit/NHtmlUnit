@ECHO OFF
echo Performing some hardcore file system nuking!
FOR /R . %%X IN (bin obj) DO RD /S /Q "%%X" 2> NUL