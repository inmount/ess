using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

/// <summary>
/// 此应用的快捷使用通道
/// </summary>
internal static partial class it {

    internal static partial class Config {

        /// <summary>
        /// 工作文件夹
        /// </summary>
        internal static string WorkFolder { get; private set; }

        /// <summary>
        /// 使用初始化
        /// </summary>
        internal static void Initialize(string path) {
            if (!path.EndsWith(it.SplitChar)) path += it.SplitChar;
            it.Config.WorkFolder = path;

            // 初始化服务配置信息
            it.Config.Server.Initialize($"{path}server.conf");
        }
    }

}
