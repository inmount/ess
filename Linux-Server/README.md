# ess

eTurm Session Server是一套基于.Net Core的开源交互信息服务端

## 安装ess服务

将源代码进行编译并使用Linux发布得到编译后的文件，拷贝到程序文件夹

将install.sh复制到程序文件夹

执行install.sh进行服务安装

## 卸载ess服务

将uninstall.sh复制到程序文件夹

执行uninstall.sh进行服务卸载

## 查看ess服务状态

```bash
$ sudo systemctl status ess 
```

## 重启ess服务状态

```bash
$ sudo systemctl restart ess 
```