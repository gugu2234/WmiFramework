using System;
using System.Management;
using WmiFramework;
namespace WmiFramework.Demo.Services
{
    /// <summary>
    /// Win32_LogicalDisk 类表示一种数据源，在 Win32 系统上，该数据源可解析到实际的本地存储设备。
    /// 该类既可返回本地磁盘，也可返回映射逻辑磁盘。然而，推荐的方法是将此类用于获取本地磁盘上的信息，而用 Win32_MappedLogicalDisk 类获取映射逻辑磁盘上的信息。
    /// </summary>
    public class Win32_LogicalDisk : WMIService<Entites.Win32_LogicalDiskEntity>
    {
        public Win32_LogicalDisk(ConnectionOptions options, string address) : base(options, address) { }
        /// <summary>
        /// SetPowerState 定义了逻辑设备所需的电源状态，并且定义了应当将设备置于此状态的时间。通过将 PowerState 参数设置为下列某个整数值，可以指定需要的电源状态: 1=“全功率”，2=“节能 - 低功耗模式”，3=“节能 - 待机”，4=“节能 - 其他”，5=“电源重启”或 6=“关闭电源”。Time 参数(适用于除了 5“电源重启”以外的其他所有状态更改)表示何时应将电源状态设置为常规日期-时间值或设置为间隔值(其中，间隔的起始时间为收到方法调用的时间)。当 PowerState 参数等于 5“电源重启”时，Time 参数表示应当再次开启设备电源的时间，关闭电源是立即执行的。如果成功，SetPowerState 应返回 0；如果指定的电源状态和时间请求不受支持，则返回 1；如果出现其他错误，则返回另外的值。在子类中，通过该方法上的 ValueMap 限定符，可以指定可能的返回代码集。还可以将“翻译”ValueMap 内容所得的字符串指定为子类中的 Values 数组限定符。
        /// </summary>
        /// <param name="PowerState"></param>
        /// <param name="Time"></param>
        /// <returns></returns>
        public uint SetPowerState(ushort PowerState, DateTime Time)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("SetPowerState");
                inParams["PowerState"] = NetValueToWmi(CimType.UInt16, PowerState);
                inParams["Time"] = NetValueToWmi(CimType.DateTime, Time);
                var output = classObj.InvokeMethod("SetPowerState", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// SetPowerState 定义了逻辑设备所需的电源状态，并且定义了应当将设备置于此状态的时间。通过将 PowerState 参数设置为下列某个整数值，可以指定需要的电源状态: 1=“全功率”，2=“节能 - 低功耗模式”，3=“节能 - 待机”，4=“节能 - 其他”，5=“电源重启”或 6=“关闭电源”。Time 参数(适用于除了 5“电源重启”以外的其他所有状态更改)表示何时应将电源状态设置为常规日期-时间值或设置为间隔值(其中，间隔的起始时间为收到方法调用的时间)。当 PowerState 参数等于 5“电源重启”时，Time 参数表示应当再次开启设备电源的时间，关闭电源是立即执行的。如果成功，SetPowerState 应返回 0；如果指定的电源状态和时间请求不受支持，则返回 1；如果出现其他错误，则返回另外的值。在子类中，通过该方法上的 ValueMap 限定符，可以指定可能的返回代码集。还可以将“翻译”ValueMap 内容所得的字符串指定为子类中的 Values 数组限定符。
        /// </summary>
        /// <param name="PowerState"></param>
        /// <param name="Time"></param>
        /// <returns></returns>
        public uint SetPowerState(Entites.Win32_LogicalDiskEntity entity, ushort PowerState, DateTime Time)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("SetPowerState");
            inParams["PowerState"] = NetValueToWmi(CimType.UInt16, PowerState);
            inParams["Time"] = NetValueToWmi(CimType.DateTime, Time);
            var output = classObj.InvokeMethod("SetPowerState", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// 请求重置逻辑设备。如果请求被成功执行，则返回的值应当为 0；如果请求不受支持，则返回 1；如果出现错误，则返回其他值。
        /// </summary>
        /// <returns></returns>
        public uint Reset()
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("Reset");
                var output = classObj.InvokeMethod("Reset", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// 请求重置逻辑设备。如果请求被成功执行，则返回的值应当为 0；如果请求不受支持，则返回 1；如果出现错误，则返回其他值。
        /// </summary>
        /// <returns></returns>
        public uint Reset(Entites.Win32_LogicalDiskEntity entity)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("Reset");
            var output = classObj.InvokeMethod("Reset", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// 此方法会在磁盘上调用 chkdsk 操作。该方法仅适用于逻辑磁盘代表机器上的物理磁盘的情况。它不适用于映射逻辑驱动器。该方法返回的值将表明以下某种情况: 成功 - chkdsk 已完成；成功 - 已锁定并计划在重新引导时执行 chkdsk；失败 - 无法识别文件系统；失败 - 出现未知错误；失败 - 不支持此文件系统。
        /// </summary>
        /// <param name="FixErrors">此参数指明针对磁盘上发现的错误所应采取的措施。如果其值为 true，则表示错误已修复。</param>
        /// <param name="ForceDismount">此参数指明在进行检查前是否应强制卸载驱动器。</param>
        /// <param name="OkToRunAtBootUp">此参数指明在下次引导启动时是否应执行 chkdsk 操作，以防止在调用该方法时因磁盘被锁定而导致操作无法执行。</param>
        /// <param name="RecoverBadSectors">此参数指明是否应找出发生故障的扇区，以及是否应从这些扇区恢复可读信息。</param>
        /// <param name="SkipFolderCycle">此参数指明是否应跳过文件夹循环检查。</param>
        /// <param name="VigorousIndexCheck">此参数指明是否需要执行有力的索引项检查。</param>
        /// <returns></returns>
        public uint Chkdsk(bool FixErrors, bool ForceDismount, bool OkToRunAtBootUp, bool RecoverBadSectors, bool SkipFolderCycle, bool VigorousIndexCheck)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("Chkdsk");
                inParams["FixErrors"] = NetValueToWmi(CimType.Boolean, FixErrors);
                inParams["ForceDismount"] = NetValueToWmi(CimType.Boolean, ForceDismount);
                inParams["OkToRunAtBootUp"] = NetValueToWmi(CimType.Boolean, OkToRunAtBootUp);
                inParams["RecoverBadSectors"] = NetValueToWmi(CimType.Boolean, RecoverBadSectors);
                inParams["SkipFolderCycle"] = NetValueToWmi(CimType.Boolean, SkipFolderCycle);
                inParams["VigorousIndexCheck"] = NetValueToWmi(CimType.Boolean, VigorousIndexCheck);
                var output = classObj.InvokeMethod("Chkdsk", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// 此方法会在磁盘上调用 chkdsk 操作。该方法仅适用于逻辑磁盘代表机器上的物理磁盘的情况。它不适用于映射逻辑驱动器。该方法返回的值将表明以下某种情况: 成功 - chkdsk 已完成；成功 - 已锁定并计划在重新引导时执行 chkdsk；失败 - 无法识别文件系统；失败 - 出现未知错误；失败 - 不支持此文件系统。
        /// </summary>
        /// <param name="FixErrors">此参数指明针对磁盘上发现的错误所应采取的措施。如果其值为 true，则表示错误已修复。</param>
        /// <param name="ForceDismount">此参数指明在进行检查前是否应强制卸载驱动器。</param>
        /// <param name="OkToRunAtBootUp">此参数指明在下次引导启动时是否应执行 chkdsk 操作，以防止在调用该方法时因磁盘被锁定而导致操作无法执行。</param>
        /// <param name="RecoverBadSectors">此参数指明是否应找出发生故障的扇区，以及是否应从这些扇区恢复可读信息。</param>
        /// <param name="SkipFolderCycle">此参数指明是否应跳过文件夹循环检查。</param>
        /// <param name="VigorousIndexCheck">此参数指明是否需要执行有力的索引项检查。</param>
        /// <returns></returns>
        public uint Chkdsk(Entites.Win32_LogicalDiskEntity entity, bool FixErrors, bool ForceDismount, bool OkToRunAtBootUp, bool RecoverBadSectors, bool SkipFolderCycle, bool VigorousIndexCheck)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("Chkdsk");
            inParams["FixErrors"] = NetValueToWmi(CimType.Boolean, FixErrors);
            inParams["ForceDismount"] = NetValueToWmi(CimType.Boolean, ForceDismount);
            inParams["OkToRunAtBootUp"] = NetValueToWmi(CimType.Boolean, OkToRunAtBootUp);
            inParams["RecoverBadSectors"] = NetValueToWmi(CimType.Boolean, RecoverBadSectors);
            inParams["SkipFolderCycle"] = NetValueToWmi(CimType.Boolean, SkipFolderCycle);
            inParams["VigorousIndexCheck"] = NetValueToWmi(CimType.Boolean, VigorousIndexCheck);
            var output = classObj.InvokeMethod("Chkdsk", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// 如果设置了更改位，则可以使用此方法计划在下次重新引导时运行 chkdsk。该方法仅适用于逻辑磁盘代表机器上的物理磁盘的情况。它不适用于映射逻辑驱动器。
        /// </summary>
        /// <param name="LogicalDisk">此参数用于指定计划在下次重新引导时运行 autochk 的驱动器列表。其字符串语法由逻辑磁盘的驱动器号组成。</param>
        /// <returns></returns>
        public uint ScheduleAutoChk(string[] LogicalDisk)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("ScheduleAutoChk");
                inParams["LogicalDisk"] = NetValueToWmi(CimType.String, LogicalDisk);
                var output = classObj.InvokeMethod("ScheduleAutoChk", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// 如果设置了更改位，则可以使用此方法计划在下次重新引导时运行 chkdsk。该方法仅适用于逻辑磁盘代表机器上的物理磁盘的情况。它不适用于映射逻辑驱动器。
        /// </summary>
        /// <param name="LogicalDisk">此参数用于指定计划在下次重新引导时运行 autochk 的驱动器列表。其字符串语法由逻辑磁盘的驱动器号组成。</param>
        /// <returns></returns>
        public uint ScheduleAutoChk(Entites.Win32_LogicalDiskEntity entity, string[] LogicalDisk)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("ScheduleAutoChk");
            inParams["LogicalDisk"] = NetValueToWmi(CimType.String, LogicalDisk);
            var output = classObj.InvokeMethod("ScheduleAutoChk", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
        /// <summary>
        /// 此方法用来将磁盘排除在下次重新引导时要运行的 chkdsk 操作之外。若不排除，则在为磁盘设置了更改位的情况下，系统就会在该磁盘上执行 chkdsk。注意，排除磁盘的调用并不是累积的。也就是说，在执行排除了某些磁盘的调用时，并不会将新的排除列表添加到已经标记为排除的磁盘列表中；相反，新的排除磁盘列表会覆盖之前的磁盘列表。该方法仅适用于逻辑磁盘代表计算机中的物理磁盘的情况，而不适用于映射逻辑驱动器。
        /// 例如，驱动器的有效规范是 "C:"、"d:"、"G:"。注意: 驱动器号必须带有冒号。
        /// </summary>
        /// <param name="LogicalDisk">此参数用于指定在下次重新引导时运行的 autochk 应排除的驱动器的列表。其字符串语法由驱动器号和紧随其后的冒号（表示逻辑磁盘）组成。</param>
        /// <returns></returns>
        public uint ExcludeFromAutochk(string[] LogicalDisk)
        {
            using (var classObj = GetClass())
            {
                var inParams = classObj.GetMethodParameters("ExcludeFromAutochk");
                inParams["LogicalDisk"] = NetValueToWmi(CimType.String, LogicalDisk);
                var output = classObj.InvokeMethod("ExcludeFromAutochk", inParams, null);
                return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
            }
        }
        /// <summary>
        /// 此方法用来将磁盘排除在下次重新引导时要运行的 chkdsk 操作之外。若不排除，则在为磁盘设置了更改位的情况下，系统就会在该磁盘上执行 chkdsk。注意，排除磁盘的调用并不是累积的。也就是说，在执行排除了某些磁盘的调用时，并不会将新的排除列表添加到已经标记为排除的磁盘列表中；相反，新的排除磁盘列表会覆盖之前的磁盘列表。该方法仅适用于逻辑磁盘代表计算机中的物理磁盘的情况，而不适用于映射逻辑驱动器。
        /// 例如，驱动器的有效规范是 "C:"、"d:"、"G:"。注意: 驱动器号必须带有冒号。
        /// </summary>
        /// <param name="LogicalDisk">此参数用于指定在下次重新引导时运行的 autochk 应排除的驱动器的列表。其字符串语法由驱动器号和紧随其后的冒号（表示逻辑磁盘）组成。</param>
        /// <returns></returns>
        public uint ExcludeFromAutochk(Entites.Win32_LogicalDiskEntity entity, string[] LogicalDisk)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("ExcludeFromAutochk");
            inParams["LogicalDisk"] = NetValueToWmi(CimType.String, LogicalDisk);
            var output = classObj.InvokeMethod("ExcludeFromAutochk", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
    }
}
