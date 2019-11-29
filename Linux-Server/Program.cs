using System;
using System.Net;

namespace ess {
    class Program {
        static void Main(string[] args) {

            // 初始化应用快捷操作通道
            it.Initialize();

            bool debug = false;

            for (int i = 0; i < args.Length; i++) {
                switch (args[i]) {
                    case "-debug":
                        debug = true;
                        break;
                }
            }

            // 以标准端参数口启动服务
            Console.WriteLine($"[+] 服务启动");
            Console.WriteLine($"[+] 调试状态 {debug}");
            dpz3.ssr.SessionServer.Server.IsDebug = debug;
            dpz3.ssr.SessionServer.Server.Build(IPAddress.Any, it.Config.Server.Password, it.Config.Server.Port, it.Config.Server.Timeout).Run();

        }
    }
}
