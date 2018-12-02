using System;
using System.Management;
using WmiFramework;
namespace WmiFramework.Demo.Services
{
    /// <summary>
    /// Win32_OperatingSystem 类表示安装在 Win32 计算机系统上的操作系统。可安装在 Win32 系统上的任何操作系统均是该类的附属(或成员)。
    /// 例如: Microsoft Windows 95。
    /// </summary>
    public class Win32_OperatingSystem : WMIService<Entites.Win32_OperatingSystemEntity>
    {
        public Win32_OperatingSystem(ConnectionOptions options, string address) : base(options, address) { }
        /// <summary>
        /// Reboot 方法关闭计算机系统，然后再重新启动。在运行 Windows NT/2000 的计算机上，调用进程必须具有 SE_SHUTDOWN_NAME 权限。
        /// 此方法返回一个整数值，其含义如下:
        /// 0 - 成功完成。
        /// 其他 - 有关上面未列出的整数值，请参阅 Win32 错误代码文档。
        /// </summary>
        /// <returns></returns>
        public uint Reboot()
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("Reboot");
                var output = classObj.InvokeMethod("Reboot", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// Reboot 方法关闭计算机系统，然后再重新启动。在运行 Windows NT/2000 的计算机上，调用进程必须具有 SE_SHUTDOWN_NAME 权限。
        /// 此方法返回一个整数值，其含义如下:
        /// 0 - 成功完成。
        /// 其他 - 有关上面未列出的整数值，请参阅 Win32 错误代码文档。
        /// </summary>
        /// <returns></returns>
        public uint Reboot(Entites.Win32_OperatingSystemEntity entity)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("Reboot");
            var output = classObj.InvokeMethod("Reboot", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// Shutdown 方法卸载程序和 DLL，直到可以安全关闭计算机。所有文件缓冲区均将被刷新到磁盘，并停止所有正在运行的进程。在运行 Windows NT/2000 的计算机系统上，调用进程必须具有 SE_SHUTDOWN_NAME 权限。
        /// 此方法返回一个整数值，其含义如下:
        /// 0 - 成功完成。
        /// 其他 - 有关上面未列出的整数值，请参阅 Win32 错误代码文档。
        /// </summary>
        /// <returns></returns>
        public uint Shutdown()
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("Shutdown");
                var output = classObj.InvokeMethod("Shutdown", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// Shutdown 方法卸载程序和 DLL，直到可以安全关闭计算机。所有文件缓冲区均将被刷新到磁盘，并停止所有正在运行的进程。在运行 Windows NT/2000 的计算机系统上，调用进程必须具有 SE_SHUTDOWN_NAME 权限。
        /// 此方法返回一个整数值，其含义如下:
        /// 0 - 成功完成。
        /// 其他 - 有关上面未列出的整数值，请参阅 Win32 错误代码文档。
        /// </summary>
        /// <returns></returns>
        public uint Shutdown(Entites.Win32_OperatingSystemEntity entity)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("Shutdown");
            var output = classObj.InvokeMethod("Shutdown", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// Win32Shutdown 方法提供 Win32 操作系统支持的整个关闭选项集合。
        /// 此方法返回一个整数值，其含义如下:
        /// 0 - 成功完成。
        /// 其他 - 有关上面未列出的整数值，请参阅 Win32 错误代码文档。
        /// </summary>
        /// <param name="Flags">Flags 参数包含关闭计算机的一系列标志。将此参数设置为 0 表示注销命令。</param>
        /// <param name="Reserved">Reserved 参数提供 Win32Shutdown 扩展方法。目前，忽略 Reserved 参数。</param>
        /// <returns></returns>
        public uint Win32Shutdown(int Flags, int Reserved)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("Win32Shutdown");
                inParams["Flags"] = NetValueToWmi(CimType.SInt32, Flags);
                inParams["Reserved"] = NetValueToWmi(CimType.SInt32, Reserved);
                var output = classObj.InvokeMethod("Win32Shutdown", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// Win32Shutdown 方法提供 Win32 操作系统支持的整个关闭选项集合。
        /// 此方法返回一个整数值，其含义如下:
        /// 0 - 成功完成。
        /// 其他 - 有关上面未列出的整数值，请参阅 Win32 错误代码文档。
        /// </summary>
        /// <param name="Flags">Flags 参数包含关闭计算机的一系列标志。将此参数设置为 0 表示注销命令。</param>
        /// <param name="Reserved">Reserved 参数提供 Win32Shutdown 扩展方法。目前，忽略 Reserved 参数。</param>
        /// <returns></returns>
        public uint Win32Shutdown(Entites.Win32_OperatingSystemEntity entity, int Flags, int Reserved)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("Win32Shutdown");
            inParams["Flags"] = NetValueToWmi(CimType.SInt32, Flags);
            inParams["Reserved"] = NetValueToWmi(CimType.SInt32, Reserved);
            var output = classObj.InvokeMethod("Win32Shutdown", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// Win32ShutdownTracker 方法提供 Win32 操作系统支持的整个关闭选项集合。
        /// 并可指定关闭和超时注释和原因，而 Win32Shutdown 方法不提供这项功能。此方法返回一个整数值，其含义如下:
        /// 0 - 成功完成。
        /// 其他 - 有关上面未列出的整数值，请参阅 Win32 错误代码文档。
        /// </summary>
        /// <param name="Comment">Comment 参数指定关闭对话框中显示的消息，以事件日志项注释的形式进行存储。</param>
        /// <param name="Flags">Flags 参数包含关闭计算机的一系列标志。将此参数设置为 0 表示注销命令。</param>
        /// <param name="ReasonCode">ReasonCode 参数指定发起关机的原因。</param>
        /// <param name="Timeout">Timeout 参数是指关闭系统前剩余的时间(秒)。默认值为 0。</param>
        /// <returns></returns>
        public uint Win32ShutdownTracker(string Comment, int Flags, uint ReasonCode, uint Timeout)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("Win32ShutdownTracker");
                inParams["Comment"] = NetValueToWmi(CimType.String, Comment);
                inParams["Flags"] = NetValueToWmi(CimType.SInt32, Flags);
                inParams["ReasonCode"] = NetValueToWmi(CimType.UInt32, ReasonCode);
                inParams["Timeout"] = NetValueToWmi(CimType.UInt32, Timeout);
                var output = classObj.InvokeMethod("Win32ShutdownTracker", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// Win32ShutdownTracker 方法提供 Win32 操作系统支持的整个关闭选项集合。
        /// 并可指定关闭和超时注释和原因，而 Win32Shutdown 方法不提供这项功能。此方法返回一个整数值，其含义如下:
        /// 0 - 成功完成。
        /// 其他 - 有关上面未列出的整数值，请参阅 Win32 错误代码文档。
        /// </summary>
        /// <param name="Comment">Comment 参数指定关闭对话框中显示的消息，以事件日志项注释的形式进行存储。</param>
        /// <param name="Flags">Flags 参数包含关闭计算机的一系列标志。将此参数设置为 0 表示注销命令。</param>
        /// <param name="ReasonCode">ReasonCode 参数指定发起关机的原因。</param>
        /// <param name="Timeout">Timeout 参数是指关闭系统前剩余的时间(秒)。默认值为 0。</param>
        /// <returns></returns>
        public uint Win32ShutdownTracker(Entites.Win32_OperatingSystemEntity entity, string Comment, int Flags, uint ReasonCode, uint Timeout)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("Win32ShutdownTracker");
            inParams["Comment"] = NetValueToWmi(CimType.String, Comment);
            inParams["Flags"] = NetValueToWmi(CimType.SInt32, Flags);
            inParams["ReasonCode"] = NetValueToWmi(CimType.UInt32, ReasonCode);
            inParams["Timeout"] = NetValueToWmi(CimType.UInt32, Timeout);
            var output = classObj.InvokeMethod("Win32ShutdownTracker", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// SetDateTime 方法设置计算机的当前系统时间。在运行 Windows NT/2000 的计算机上，调用进程必须具有 SE_SYSTEMTIME_NAME 权限。
        /// 此方法返回一个整数值，其含义如下:
        /// 0 - 成功完成。
        /// 其他 - 有关上面未列出的整数值，请参阅 Win32 错误代码文档。
        /// </summary>
        /// <param name="LocalDateTime">LocalDateTime 参数是要设置的时间。此属性不能为 NULL。</param>
        /// <returns></returns>
        public uint SetDateTime(DateTime LocalDateTime)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("SetDateTime");
                inParams["LocalDateTime"] = NetValueToWmi(CimType.DateTime, LocalDateTime);
                var output = classObj.InvokeMethod("SetDateTime", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// SetDateTime 方法设置计算机的当前系统时间。在运行 Windows NT/2000 的计算机上，调用进程必须具有 SE_SYSTEMTIME_NAME 权限。
        /// 此方法返回一个整数值，其含义如下:
        /// 0 - 成功完成。
        /// 其他 - 有关上面未列出的整数值，请参阅 Win32 错误代码文档。
        /// </summary>
        /// <param name="LocalDateTime">LocalDateTime 参数是要设置的时间。此属性不能为 NULL。</param>
        /// <returns></returns>
        public uint SetDateTime(Entites.Win32_OperatingSystemEntity entity, DateTime LocalDateTime)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("SetDateTime");
            inParams["LocalDateTime"] = NetValueToWmi(CimType.DateTime, LocalDateTime);
            var output = classObj.InvokeMethod("SetDateTime", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
    }
}
