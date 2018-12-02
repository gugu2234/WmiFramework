using System;
using System.Management;
using WMIAccess;
namespace WmiOperate.Services
{
    /// <summary>
    /// Win32_Process 类表示 Win32 系统上的事件序列。包含一个或多个处理器或解释器、某种可执行代码和输入集的任何序列均为此类的附属(或成员)。
    /// 例如: Win32 系统上运行的客户端应用程序。
    /// </summary>
    public class Win32_Process : WMIService<Entites.Win32_ProcessEntity>
    {
        public Win32_Process(ConnectionOptions options, string address) : base(options, address) { }
        /// <summary>
        /// Create 方法新建进程。
        /// 此方法返回一个整数值，其含义如下:
        /// 0 - 成功完成；
        /// 2 - 用户无法访问所请求的信息；
        /// 3 - 用户没有足够的特权；
        /// 8 - 出现未知故障；
        /// 9 - 指定的路径不存在；
        /// 21 - 指定的参数无效；
        /// 其他 - 有关上面未列出的整数值，请参阅 Win32 错误代码文档。
        /// </summary>
        /// <param name="CommandLine">CommandLine 参数指定要执行的命令行。系统会向命令行添加 null 字符，并在必要时调整字符串，以指明实际使用的文件。如果要启动的程序不在 Winmgmt 的搜索路径(非用户路径)中，必须指定完全限定的路径。</param>
        /// <param name="CurrentDirectory">CurrentDirectory 参数指定子进程的当前驱动器和目录。该字符串要求将当前目录解析为已知路径。用户可以指定绝对路径或与当前工作目录相关的路径。如果此参数为 NULL，新进程的路径将与调用进程的路径相同。此选项主要用于必须启动应用程序并指定应用程序初始驱动器和工作目录的外壳程序。</param>
        /// <param name="ProcessStartupInformation">ProcessStartupInformation 参数表示 Win32 进程的启动配置。它包括有关显示窗口，控制台应用程序特性和错误处理的信息。
        /// 
        /// 注意，在 Windows XP 及更高版本中，无论在任何情况下均忽视 WinstationDesktop 字符串属性(从前默认为 "winsta0\default")。替代此参数的值是空字符串("")。</param>
        /// <param name="ProcessId">ProcessId 参数返回可用于识别进程的全局进程标识符。该值自进程创建开始至进程终止一直有效。</param>
        /// <param name="ReturnValue"></param>
        public void Create(string CommandLine, string CurrentDirectory, object ProcessStartupInformation, out uint ProcessId, out uint ReturnValue)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("Create");
                inParams["CommandLine"] = NetValueToWmi(CimType.String, CommandLine);
                inParams["CurrentDirectory"] = NetValueToWmi(CimType.String, CurrentDirectory);
                inParams["ProcessStartupInformation"] = NetValueToWmi(CimType.Object, ProcessStartupInformation);
                var output = classObj.InvokeMethod("Create", inParams, null);
                ProcessId = (uint)output["ProcessId"];
                ReturnValue = (uint)output["ReturnValue"];
            }
        }
        /// <summary>
        /// Create 方法新建进程。
        /// 此方法返回一个整数值，其含义如下:
        /// 0 - 成功完成；
        /// 2 - 用户无法访问所请求的信息；
        /// 3 - 用户没有足够的特权；
        /// 8 - 出现未知故障；
        /// 9 - 指定的路径不存在；
        /// 21 - 指定的参数无效；
        /// 其他 - 有关上面未列出的整数值，请参阅 Win32 错误代码文档。
        /// </summary>
        /// <param name="CommandLine">CommandLine 参数指定要执行的命令行。系统会向命令行添加 null 字符，并在必要时调整字符串，以指明实际使用的文件。如果要启动的程序不在 Winmgmt 的搜索路径(非用户路径)中，必须指定完全限定的路径。</param>
        /// <param name="CurrentDirectory">CurrentDirectory 参数指定子进程的当前驱动器和目录。该字符串要求将当前目录解析为已知路径。用户可以指定绝对路径或与当前工作目录相关的路径。如果此参数为 NULL，新进程的路径将与调用进程的路径相同。此选项主要用于必须启动应用程序并指定应用程序初始驱动器和工作目录的外壳程序。</param>
        /// <param name="ProcessStartupInformation">ProcessStartupInformation 参数表示 Win32 进程的启动配置。它包括有关显示窗口，控制台应用程序特性和错误处理的信息。
        /// 
        /// 注意，在 Windows XP 及更高版本中，无论在任何情况下均忽视 WinstationDesktop 字符串属性(从前默认为 "winsta0\default")。替代此参数的值是空字符串("")。</param>
        /// <param name="ProcessId">ProcessId 参数返回可用于识别进程的全局进程标识符。该值自进程创建开始至进程终止一直有效。</param>
        /// <param name="ReturnValue"></param>
        public void Create(Entites.Win32_ProcessEntity entity, string CommandLine, string CurrentDirectory, object ProcessStartupInformation, out uint ProcessId, out uint ReturnValue)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("Create");
            inParams["CommandLine"] = NetValueToWmi(CimType.String, CommandLine);
            inParams["CurrentDirectory"] = NetValueToWmi(CimType.String, CurrentDirectory);
            inParams["ProcessStartupInformation"] = NetValueToWmi(CimType.Object, ProcessStartupInformation);
            var output = classObj.InvokeMethod("Create", inParams, null);
            ProcessId = (uint)output["ProcessId"];
            ReturnValue = (uint)output["ReturnValue"];
        }
        /// <summary>
        /// Terminate 方法终止进程及其所有线程。此方法返回一个整数值，其含义如下:
        /// 0 - 成功完成；
        /// 2 - 用户无法访问所请求的信息；
        /// 3 - 用户没有足够的特权；
        /// 8 - 出现未知故障；
        /// 9 - 指定的路径不存在；
        /// 21 - 指定的参数无效；
        /// 其他 - 有关上面未列出的整数值，请参阅 Win32 错误代码文档。
        /// 
        /// 注意: 调用此方法要求具备 SE_DEBUG_PRIVILEGE 权限
        /// </summary>
        /// <param name="Reason">Reason 参数指定进程的退出代码以及由于这项调用而终止的所有线程。</param>
        /// <returns></returns>
        public uint Terminate(uint Reason)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("Terminate");
                inParams["Reason"] = NetValueToWmi(CimType.UInt32, Reason);
                var output = classObj.InvokeMethod("Terminate", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// Terminate 方法终止进程及其所有线程。此方法返回一个整数值，其含义如下:
        /// 0 - 成功完成；
        /// 2 - 用户无法访问所请求的信息；
        /// 3 - 用户没有足够的特权；
        /// 8 - 出现未知故障；
        /// 9 - 指定的路径不存在；
        /// 21 - 指定的参数无效；
        /// 其他 - 有关上面未列出的整数值，请参阅 Win32 错误代码文档。
        /// 
        /// 注意: 调用此方法要求具备 SE_DEBUG_PRIVILEGE 权限
        /// </summary>
        /// <param name="Reason">Reason 参数指定进程的退出代码以及由于这项调用而终止的所有线程。</param>
        /// <returns></returns>
        public uint Terminate(Entites.Win32_ProcessEntity entity, uint Reason)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("Terminate");
            inParams["Reason"] = NetValueToWmi(CimType.UInt32, Reason);
            var output = classObj.InvokeMethod("Terminate", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// GetOwner 方法检索运行此进程的用户名和域名。
        /// 此方法返回一个整数值，其含义如下:
        /// 0 - 成功完成；
        /// 2 - 用户无法访问所请求的信息；
        /// 3 - 用户没有足够的特权；
        /// 8 - 出现未知故障；
        /// 9 - 指定的路径不存在；
        /// 21 - 指定的参数无效；
        /// 其他 - 有关上面未列出的整数值，请参阅 Win32 错误代码文档。
        /// </summary>
        /// <param name="Domain">Domain 参数返回运行此进程的域名。</param>
        /// <param name="ReturnValue"></param>
        /// <param name="User">User 参数返回此进程所有者的名称。</param>
        public void GetOwner(out string Domain, out uint ReturnValue, out string User)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("GetOwner");
                var output = classObj.InvokeMethod("GetOwner", inParams, null);
                Domain = (string)output["Domain"];
                ReturnValue = (uint)output["ReturnValue"];
                User = (string)output["User"];
            }
        }
        /// <summary>
        /// GetOwner 方法检索运行此进程的用户名和域名。
        /// 此方法返回一个整数值，其含义如下:
        /// 0 - 成功完成；
        /// 2 - 用户无法访问所请求的信息；
        /// 3 - 用户没有足够的特权；
        /// 8 - 出现未知故障；
        /// 9 - 指定的路径不存在；
        /// 21 - 指定的参数无效；
        /// 其他 - 有关上面未列出的整数值，请参阅 Win32 错误代码文档。
        /// </summary>
        /// <param name="Domain">Domain 参数返回运行此进程的域名。</param>
        /// <param name="ReturnValue"></param>
        /// <param name="User">User 参数返回此进程所有者的名称。</param>
        public void GetOwner(Entites.Win32_ProcessEntity entity, out string Domain, out uint ReturnValue, out string User)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("GetOwner");
            var output = classObj.InvokeMethod("GetOwner", inParams, null);
            Domain = (string)output["Domain"];
            ReturnValue = (uint)output["ReturnValue"];
            User = (string)output["User"];
        }
        /// <summary>
        /// GetOwnerSid 方法检索此进程所有者的安全标识符(SID)。
        /// 此方法返回一个整数值，其含义如下:
        /// 0 - 成功完成；
        /// 2 - 用户无法访问所请求的信息；
        /// 3 - 用户没有足够的特权；
        /// 8 - 出现未知故障；
        /// 9 - 指定的路径不存在；
        /// 21 - 指定的参数无效；
        /// 其他 - 有关上面未列出的整数值，请参阅 Win32 错误代码文档。。
        /// </summary>
        /// <param name="ReturnValue"></param>
        /// <param name="Sid">Sid 属性返回该进程的安全标识符描述符。</param>
        public void GetOwnerSid(out uint ReturnValue, out string Sid)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("GetOwnerSid");
                var output = classObj.InvokeMethod("GetOwnerSid", inParams, null);
                ReturnValue = (uint)output["ReturnValue"];
                Sid = (string)output["Sid"];
            }
        }
        /// <summary>
        /// GetOwnerSid 方法检索此进程所有者的安全标识符(SID)。
        /// 此方法返回一个整数值，其含义如下:
        /// 0 - 成功完成；
        /// 2 - 用户无法访问所请求的信息；
        /// 3 - 用户没有足够的特权；
        /// 8 - 出现未知故障；
        /// 9 - 指定的路径不存在；
        /// 21 - 指定的参数无效；
        /// 其他 - 有关上面未列出的整数值，请参阅 Win32 错误代码文档。。
        /// </summary>
        /// <param name="ReturnValue"></param>
        /// <param name="Sid">Sid 属性返回该进程的安全标识符描述符。</param>
        public void GetOwnerSid(Entites.Win32_ProcessEntity entity, out uint ReturnValue, out string Sid)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("GetOwnerSid");
            var output = classObj.InvokeMethod("GetOwnerSid", inParams, null);
            ReturnValue = (uint)output["ReturnValue"];
            Sid = (string)output["Sid"];
        }
        /// <summary>
        /// SetPriority 方法尝试更改此进程的执行优先级。为将优先级设置为“实时”，调用程序必须具有 SeIncreaseBasePriorityPrivilege。若不具备该权限，最高可将该优先级设置为“高”优先级。
        /// 此方法返回一个整数值，其含义如下:
        /// 0 - 成功完成；
        /// 2 - 用户无法访问所请求的信息；
        /// 3 - 用户没有足够的特权；
        /// 8 - 出现未知故障；
        /// 9 - 指定的路径不存在；
        /// 21 - 指定的参数无效；
        /// 其他 - 有关上面未列出的整数值，请参阅 Win32 错误代码文档。
        /// </summary>
        /// <param name="Priority">Priority 参数为此进程指定新的优先级类。值:
        /// 空闲 - 具有该值的进程只有当系统闲置时才会运行其线程。该进程的线程优先级低于较高优先级类中运行的所有进程的线程。例如，屏幕保护程序。子进程将继承“空闲”优先级类。
        /// 低于正常 - 表示优先级高于 IDLE_PRIORITY_CLASS 但低于 NORMAL_PRIORITY_CLASS 的进程。适用于 Windows 2000。
        /// 正常 - 表示无任何特殊计划需求的进程。
        /// 高于正常 - 表示优先级高于 NORMAL_PRIORITY_CLASS 但低于 HIGH_PRIORITY_CLASS 的进程。适用于 Windows 2000。
        /// 高优先级 - 指定开展必须立即执行的时间关键任务的进程。该进程的线程优先于“正常”优先级或“空闲”优先级类进程的线程。任务列表就是一个例子，无论负载是否位于操作系统，均必须在用户调用时迅速做出响应。使用“高”优先级类时要格外小心，因为“高”优先级类应用程序可能会占用几乎全部可用 CPU 时间。
        /// 实时 - 指定优先级最高的进程。该进程的线程优先于其他所有进程的线程，包括执行重要任务的操作系统进程。例如，实时进程的执行时间间隔稍长就会导致磁盘缓存无法刷新或鼠标无法响应。
        /// </param>
        /// <returns></returns>
        public uint SetPriority(int Priority)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("SetPriority");
                inParams["Priority"] = NetValueToWmi(CimType.SInt32, Priority);
                var output = classObj.InvokeMethod("SetPriority", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// SetPriority 方法尝试更改此进程的执行优先级。为将优先级设置为“实时”，调用程序必须具有 SeIncreaseBasePriorityPrivilege。若不具备该权限，最高可将该优先级设置为“高”优先级。
        /// 此方法返回一个整数值，其含义如下:
        /// 0 - 成功完成；
        /// 2 - 用户无法访问所请求的信息；
        /// 3 - 用户没有足够的特权；
        /// 8 - 出现未知故障；
        /// 9 - 指定的路径不存在；
        /// 21 - 指定的参数无效；
        /// 其他 - 有关上面未列出的整数值，请参阅 Win32 错误代码文档。
        /// </summary>
        /// <param name="Priority">Priority 参数为此进程指定新的优先级类。值:
        /// 空闲 - 具有该值的进程只有当系统闲置时才会运行其线程。该进程的线程优先级低于较高优先级类中运行的所有进程的线程。例如，屏幕保护程序。子进程将继承“空闲”优先级类。
        /// 低于正常 - 表示优先级高于 IDLE_PRIORITY_CLASS 但低于 NORMAL_PRIORITY_CLASS 的进程。适用于 Windows 2000。
        /// 正常 - 表示无任何特殊计划需求的进程。
        /// 高于正常 - 表示优先级高于 NORMAL_PRIORITY_CLASS 但低于 HIGH_PRIORITY_CLASS 的进程。适用于 Windows 2000。
        /// 高优先级 - 指定开展必须立即执行的时间关键任务的进程。该进程的线程优先于“正常”优先级或“空闲”优先级类进程的线程。任务列表就是一个例子，无论负载是否位于操作系统，均必须在用户调用时迅速做出响应。使用“高”优先级类时要格外小心，因为“高”优先级类应用程序可能会占用几乎全部可用 CPU 时间。
        /// 实时 - 指定优先级最高的进程。该进程的线程优先于其他所有进程的线程，包括执行重要任务的操作系统进程。例如，实时进程的执行时间间隔稍长就会导致磁盘缓存无法刷新或鼠标无法响应。
        /// </param>
        /// <returns></returns>
        public uint SetPriority(Entites.Win32_ProcessEntity entity, int Priority)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("SetPriority");
            inParams["Priority"] = NetValueToWmi(CimType.SInt32, Priority);
            var output = classObj.InvokeMethod("SetPriority", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// AttachDebugger 方法为此进程启动当前已注册的调试程序。但并不支持 Dr. Watson。
        /// 该方法将返回“常规错误”(如果在注册表项中发现无效字符串)或整数值，其含义如下:
        /// 0 - 成功完成；
        /// 2 - 用户无法访问所请求的信息；
        /// 3 - 用户没有足够的特权；
        /// 8 - 出现未知故障；
        /// 9 - 指定的路径不存在；
        /// 21 - 指定的参数无效；
        /// 其他 - 有关上面未列出的整数值，请参阅 Win32 错误代码文档。
        /// </summary>
        /// <returns></returns>
        public uint AttachDebugger()
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("AttachDebugger");
                var output = classObj.InvokeMethod("AttachDebugger", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// AttachDebugger 方法为此进程启动当前已注册的调试程序。但并不支持 Dr. Watson。
        /// 该方法将返回“常规错误”(如果在注册表项中发现无效字符串)或整数值，其含义如下:
        /// 0 - 成功完成；
        /// 2 - 用户无法访问所请求的信息；
        /// 3 - 用户没有足够的特权；
        /// 8 - 出现未知故障；
        /// 9 - 指定的路径不存在；
        /// 21 - 指定的参数无效；
        /// 其他 - 有关上面未列出的整数值，请参阅 Win32 错误代码文档。
        /// </summary>
        /// <returns></returns>
        public uint AttachDebugger(Entites.Win32_ProcessEntity entity)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("AttachDebugger");
            var output = classObj.InvokeMethod("AttachDebugger", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// GetAvailableVirtualSize 方法检索可用于此进程的可用虚拟地址空间的当前大小(以字节为单位)。
        /// 该方法返回一个整数值，可作如下解释: 
        /// 0 - 成功完成。
        /// 2 - 用户无法访问请求的信息。
        /// 3 - 用户没有足够的权限。
        /// 8 - 未知故障。
        /// 9 - 指定的路径不存在。
        /// 21 - 指定的参数无效。
        /// 其他 - 有关上面所列以外的整数值，请参阅 Win32 错误代码文档。
        /// </summary>
        /// <param name="AvailableVirtualSize">AvailableVirtualSize 属性返回可用于此进程的可用虚拟地址空间。</param>
        /// <param name="ReturnValue"></param>
        public void GetAvailableVirtualSize(out ulong AvailableVirtualSize, out uint ReturnValue)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("GetAvailableVirtualSize");
                var output = classObj.InvokeMethod("GetAvailableVirtualSize", inParams, null);
                AvailableVirtualSize = (ulong)output["AvailableVirtualSize"];
                ReturnValue = (uint)output["ReturnValue"];
            }
        }
        /// <summary>
        /// GetAvailableVirtualSize 方法检索可用于此进程的可用虚拟地址空间的当前大小(以字节为单位)。
        /// 该方法返回一个整数值，可作如下解释: 
        /// 0 - 成功完成。
        /// 2 - 用户无法访问请求的信息。
        /// 3 - 用户没有足够的权限。
        /// 8 - 未知故障。
        /// 9 - 指定的路径不存在。
        /// 21 - 指定的参数无效。
        /// 其他 - 有关上面所列以外的整数值，请参阅 Win32 错误代码文档。
        /// </summary>
        /// <param name="AvailableVirtualSize">AvailableVirtualSize 属性返回可用于此进程的可用虚拟地址空间。</param>
        /// <param name="ReturnValue"></param>
        public void GetAvailableVirtualSize(Entites.Win32_ProcessEntity entity, out ulong AvailableVirtualSize, out uint ReturnValue)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("GetAvailableVirtualSize");
            var output = classObj.InvokeMethod("GetAvailableVirtualSize", inParams, null);
            AvailableVirtualSize = (ulong)output["AvailableVirtualSize"];
            ReturnValue = (uint)output["ReturnValue"];
        }
    }
}
