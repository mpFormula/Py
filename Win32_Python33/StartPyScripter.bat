@ECHO OFF
SET PYTHONHOME=%~dp0
Start "" PyScripter --PYTHON33 --PYTHONDLLPATH="%~dp0" %1 %2 %3 %4 %5
Exit