using System;
using System.ServiceProcess;

namespace ess {
    class Program {
        static void Main(string[] args) {

            // 初始化应用快捷操作通道
            it.Initialize();

            ServiceBase[] services = new ServiceBase[] { new Service1() };
            ServiceBase.Run(services);
        }
    }
}
