@echo off

echo [+] ��װ���߳�ʼ�� ...
set dir=%~dp0
set file=%dir%ess.exe
echo %file%

echo [+] ��װ���� ...
sc create "eTurm Session Server" binpath= "%file%" displayname= "eTurm Session Server" type= share start= auto

pause