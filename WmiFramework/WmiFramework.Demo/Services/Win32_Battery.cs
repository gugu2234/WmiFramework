using System;
using System.Management;
using WmiFramework;
namespace WmiFramework.Demo.Services
{
    /// <summary>
    /// Win32_Battery 类表示连接到计算机系统的电池。该类适用于笔记本电脑系统的电池及其他内部/外部电池。
    /// </summary>
    public class Win32_Battery : WMIService<Entites.Win32_BatteryEntity>
    {
        public Win32_Battery(ConnectionOptions options, string address) : base(options, address) { }
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
        public uint SetPowerState(Entites.Win32_BatteryEntity entity, ushort PowerState, DateTime Time)
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
        public uint Reset(Entites.Win32_BatteryEntity entity)
        {
            var classObj = GetEntityWmiObjecj(entity);
            var inParams = classObj.GetMethodParameters("Reset");
            var output = classObj.InvokeMethod("Reset", inParams, null);
            return (uint)WmiValueToNet(CimType.UInt32, output["ReturnValue"]);
        }
    }
}
