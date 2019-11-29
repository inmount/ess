#!/bin/bash

# run with root
user=`whoami`
if [ "$user" != "root" ]; then
    echo "[+] restart with sudo ..."
	sudo $0
    exit 1
fi

# info
serverName="ess"
serverFile="/etc/systemd/system/$serverName.service"
serverDec="eTurm Session Server"
execFolder=`pwd`
execFile="$execFolder/ess"

echo "[+] stop service ..."
systemctl stop $serverName

echo "[+] disable service ..."
systemctl disable $serverName

echo "[+] delete file $serverFile ..."
rm -rf $serverFile

echo "[+] reload services ..."
systemctl daemon-reload