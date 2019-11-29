using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

/// <summary>
/// 此应用的快捷使用通道
/// </summary>
internal static partial class it {

    /// <summary>
    /// 目录分隔符
    /// </summary>
    internal static char SplitChar { get; private set; }

    /// <summary>
    /// 工作目录
    /// </summary>
    internal static string WorkPath { get; private set; }

    /// <summary>
    /// 执行目录
    /// </summary>
    internal static string ExecPath { get; private set; }

    /// <summary>
    /// 使用初始化
    /// </summary>
    internal static void Initialize() {

        // 设置目录分隔符
        char pathSplit = '/';
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) pathSplit = '\\';
        it.SplitChar = pathSplit;

        // 获取执行目录
        string execpath = AppContext.BaseDirectory;
        if (!execpath.EndsWith(pathSplit)) execpath += pathSplit;
        it.ExecPath = execpath;

        // 获取工作目录
        string workpath = System.IO.Directory.GetCurrentDirectory();
        if (!workpath.EndsWith(pathSplit)) workpath += pathSplit;
        it.WorkPath = workpath;

        // 初始化设置类
        string cfgPath = $"{it.ExecPath}Conf";
        if (!System.IO.Directory.Exists(cfgPath)) System.IO.Directory.CreateDirectory(cfgPath);
        it.Config.Initialize(cfgPath);

    }

}
