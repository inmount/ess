using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using dpz3;

/// <summary>
/// 此应用的快捷使用通道
/// </summary>
internal static partial class it {

    internal static partial class Config {

        internal static class Server {

            /// <summary>
            /// 端口号
            /// </summary>
            internal static int Port { get; private set; }

            /// <summary>
            /// 通讯密码
            /// </summary>
            internal static string Password { get; private set; }

            /// <summary>
            /// 数据存储超市
            /// </summary>
            internal static int Timeout { get; private set; }

            /// <summary>
            /// 使用初始化
            /// </summary>
            internal static void Initialize(string path) {

                // 创建默认配置
                if (!System.IO.File.Exists(path)) {
                    using (var cfg = new dpz3.File.ConfFile(path)) {
                        var group = cfg["default"];
                        group["port"] = "8601";
                        group["passwd"] = "000000";
                        group["timeout"] = "3600";
                        cfg.Save();
                    }
                }

                using (var cfg = new dpz3.File.ConfFile(path)) {
                    var group = cfg["default"];
                    Port = group["port"].ToInteger();
                    Password = group["passwd"];
                    Timeout = group["timeout"].ToInteger();
                }

            }

        }
    }

}
