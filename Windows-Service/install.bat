@echo off

echo [+] 安装工具初始化 ...
set dir=%~dp0
set file=%dir%ess.exe
echo %file%

echo [+] 安装服务 ...
sc create "eTurm Session Server" binpath= "%file%" displayname= "eTurm Session Server" type= share start= auto

pause