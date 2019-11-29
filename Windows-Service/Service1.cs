using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Net;
using System.ServiceProcess;
using System.Text;

namespace ess {
    partial class Service1 : ServiceBase {

        private dpz3.ssr.SessionServer.Server _server;

        public Service1() {
            InitializeComponent();
            _server = new dpz3.ssr.SessionServer.Server(IPAddress.Any, it.Config.Server.Password, it.Config.Server.Port, it.Config.Server.Timeout);
        }

        protected override void OnStart(string[] args) {
            // TODO: 在此处添加代码以启动服务。
            _server.Start();
        }

        protected override void OnStop() {
            // TODO: 在此处添加代码以执行停止服务所需的关闭操作。
            _server.Stop();
        }
    }
}
