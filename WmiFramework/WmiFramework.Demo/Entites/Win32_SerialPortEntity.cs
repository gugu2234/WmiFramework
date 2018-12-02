using System;
using WmiFramework;
namespace WmiFramework.Demo.Entites
{
    /// <summary>
    /// Win32_SerialPort 类表示 Win32 系统上的串行端口。
    /// </summary>
   [Classes("Win32_SerialPort", @"ROOT\CIMV2")]
    public class Win32_SerialPortEntity : EntityBase
    {
       /// <summary>
       /// 设备的可用性和状态。例如: Availability 属性可以指明设备正在运行并且为全功率(值=3)、或者处于警告(4)、测试(5)、降级(10)或节能状态(值为 13-15 和 17)。有关节能状态，其定义如下所示: 值 13 (“节能 - 未知”)表示设备处于节能模式，但是它在该模式中的准确状态未知；14 (“节能 - 低功耗模式”)表示设备处于节能状态，但仍然正常运转，可能会出现性能下降；15 (“节能 - 待机”)表示设备没有正常运转，但是可以“快速”转入全功率工作状态；值为 17 (“节能 - 警告”)时表示设备虽然处于节能模式，但它的状态是警告状态。
       /// </summary>
       public ushort Availability { get; set; }
       /// <summary>
       /// Binary 属性指明是否为串行端口配置二进制数据传输。由于 Win32 API 不支持非二进制模式传输，因此，该属性必须为 TRUE。指定 FALSE 不起作用。值: TRUE 或 FALSE。值 TRUE 表示为串行端口配置二进制数据传输。
       /// </summary>
       public bool Binary { get; set; }
       /// <summary>
       /// Capabilities 属性定义串行控制器的芯片级兼容性。因此，该属性描述了芯片硬件中固有的串行控制器的缓冲和其他功能。该属性是一个枚举型整数。
       /// </summary>
       public ushort[] Capabilities { get; set; }
       /// <summary>
       /// 一个自由格式字符串数组，用于为“功能”数组中指出的任何串行控制器功能提供更为详细的说明。请注意：此数组的每一项都与“功能”数组中具有相同索引的项目关联。
       /// </summary>
       public string[] CapabilityDescriptions { get; set; }
       public string Caption { get; set; }
       /// <summary>
       /// 指明 Win32 配置管理器错误代码。可能返回下列值: 
       /// 0     此设备运行正常。
       /// 1     此设备的配置不正确。
       /// 2     Windows 无法为此设备加载驱动程序。
       /// 3     此设备的驱动程序可能已损坏，或者系统内存或其他资源不足。
       /// 4     此设备不能正常运行。某个驱动程序或注册表可能已损坏。
       /// 5     此设备的驱动程序需要一个 Windows 无法管理的资源。
       /// 6     此设备的引导配置与其他设备冲突。
       /// 7     无法筛选。
       /// 8     找不到此设备的驱动程序加载器。
       /// 9     由于控制固件没有正确报告此设备的资源，所以该设备无法正常运行。
       /// 10     此设备无法启动。
       /// 11     此设备失败。
       /// 12     此设备无法找到足够的可用空闲资源。
       /// 13     Windows 无法识别此设备的资源。
       /// 14     重新启动计算机之前，此设备无法正常运行。
       /// 15     由于可能存在重新枚举的问题，所以此设备无法正常运行。
       /// 16     Windows 无法识别此设备使用的所有资源。
       /// 17     此设备正在请求未知的资源类型。
       /// 18     为此设备重新安装驱动程序。
       /// 19     你的注册表可能已损坏。
       /// 20     使用 VxD 加载器失败。
       /// 21     系统失败: 请尝试更改此设备的驱动程序。如果仍然无效，请参阅你的硬件文档。Windows 正在删除此设备。
       /// 22     此设备已被禁用。
       /// 23     系统失败: 请尝试更改此设备的驱动程序。如果仍然无效，请参阅你的硬件文档。
       /// 24     此设备不存在、无法正常运行或者没有安装所有的驱动程序。
       /// 25     Windows 仍在安装此设备。
       /// 26     Windows 仍在安装此设备。
       /// 27     此设备的日志配置无效。
       /// 28     没有安装此设备的驱动程序。
       /// 29     由于此设备的固件没有提供所需资源，所以此设备已被禁用。
       /// 30     此设备正在使用另一台设备使用的中断请求(IRQ)资源。
       /// 31     由于 Windows 无法加载此设备所需的驱动程序，所以此设备无法正常运行。
       /// </summary>
       public uint ConfigManagerErrorCode { get; set; }
       /// <summary>
       /// 指明设备是否使用用户定义的配置。
       /// </summary>
       public bool ConfigManagerUserConfig { get; set; }
       /// <summary>
       /// CreationClassName 指明创建实例时使用的类或子类的名称。与此类的其他键属性一起使用时，此属性可唯一标识此类及其子类的所有实例。
       /// </summary>
       public string CreationClassName { get; set; }
       public string Description { get; set; }
       /// <summary>
       /// DeviceID 属性包含一个唯一地标识串行端口的字符串，以将其与系统上的其他设备区分开。
       /// </summary>
       public string DeviceID { get; set; }
       /// <summary>
       /// ErrorCleared 是一个布尔值属性，指明 LastErrorCode 属性中报告的错误现已清除。
       /// </summary>
       public bool ErrorCleared { get; set; }
       /// <summary>
       /// ErrorDescription 是一个自由格式字符串，提供有关 LastErrorCode 属性中记录的错误的详细信息，以及有关可以采取的纠正措施的信息。
       /// </summary>
       public string ErrorDescription { get; set; }
       public DateTime InstallDate { get; set; }
       /// <summary>
       /// LastErrorCode 捕获由逻辑设备报告的最后一个错误代码。
       /// </summary>
       public uint LastErrorCode { get; set; }
       /// <summary>
       /// SerialController 支持的最大波特率(位/秒)。
       /// </summary>
       public uint MaxBaudRate { get; set; }
       /// <summary>
       /// MaximumInputBufferSize 属性指明串行端口驱动程序的内部输入缓冲区的最大容量。零值表示串行提供程序未设置最大值。
       /// </summary>
       public uint MaximumInputBufferSize { get; set; }
       /// <summary>
       /// MaximumOutputBufferSize 属性指定串行端口驱动程序的内部输出缓冲区的最大容量。零值表示串行提供程序未设置最大值。
       /// </summary>
       public uint MaximumOutputBufferSize { get; set; }
       /// <summary>
       /// 此控制器支持的可直接寻址的实体的最大数目。如果数目未知或没有限制，则可以使用值 0。
       /// </summary>
       public uint MaxNumberControlled { get; set; }
       public string Name { get; set; }
       /// <summary>
       /// OSAutoDiscovered 属性区分由操作系统自动发现的该类的实例。例如，通过控制面板添加了硬件之后，操作系统通过从该类的实例中查询硬件来找到该类的实例。值 TRUE 表示实例是自动发现的。
       /// </summary>
       public bool OSAutoDiscovered { get; set; }
       /// <summary>
       /// 指明逻辑设备的 Win32 即插即用设备 ID。例如: *PNP030b
       /// </summary>
       public string PNPDeviceID { get; set; }
       /// <summary>
       /// 指明逻辑设备中与电源有关的特定功能。数组值 0=“未知”，1=“不支持”和 2=“已禁用”代表的含义一目了然。值 3=“已启用”表示当前已启用电源管理功能，但是具体的功能集未知或者信息无效。“自动进入节能模式”(4)表示设备可根据用途或其他条件更改其电源状态。“可设置电源状态”(5)表示支持 SetPowerState 方法。“支持电源重启”(6)表示可以通过将 PowerState 输入变量设置为 5 (“电源重启”)来调用 SetPowerState 方法。“支持定时通电”(7)表示可以通过将 PowerState 输入变量设置为 5 (“电源重启”)、Time 参数设置为具体的通电日期和时间或间隔，调用 SetPowerState 方法。
       /// </summary>
       public ushort[] PowerManagementCapabilities { get; set; }
       /// <summary>
       /// 布尔值，指明设备是否支持电源管理，即进入节能状态。该布尔值并不表示当前启用了电源管理功能；或者，如果已经启用了电源管理功能，该布尔值也并不表示支持具体的功能。相关信息，请参阅 PowerManagementCapabilities 数组。如果此布尔值为 False，那么在 PowerManagementCapabilities 数组中，整数值为 1 的字符串“不支持”应是仅有的条目。
       /// </summary>
       public bool PowerManagementSupported { get; set; }
       /// <summary>
       /// 控制器访问“控制的”设备时使用的协议。
       /// </summary>
       public ushort ProtocolSupported { get; set; }
       /// <summary>
       /// ProviderType 属性指定通信提供程序类型。
       /// </summary>
       public string ProviderType { get; set; }
       /// <summary>
       /// SettableBaudRate 属性指明是否可以更改该串行端口的波特率。
       /// 值: TRUE 或 FALSE。值 TRUE 表示可以更改波特率。
       /// </summary>
       public bool SettableBaudRate { get; set; }
       /// <summary>
       /// SettableDataBits 属性指明是否可以为该串行端口设置数据位。
       /// 值: TRUE 或 FALSE。值 TRUE 表示可以设置数据位。
       /// </summary>
       public bool SettableDataBits { get; set; }
       /// <summary>
       /// SettableFlowControl 属性指明是否可以为该串行端口设置流控制。
       /// 值: TRUE 或 FALSE。值 TRUE 表示可以设置流控制。
       /// </summary>
       public bool SettableFlowControl { get; set; }
       /// <summary>
       /// SettableParity 属性指明是否可以为该串行端口设置奇偶校验。
       /// 值: TRUE 或 FALSE。值 TRUE 表示可以设置奇偶校验。
       /// </summary>
       public bool SettableParity { get; set; }
       /// <summary>
       /// SettableParityCheck 属性指明是否可以为该串行端口设置奇偶校验检查(如果支持奇偶校验检查)。
       /// 值: TRUE 或 FALSE。值 TRUE 表示可以设置奇偶校验检查。
       /// </summary>
       public bool SettableParityCheck { get; set; }
       /// <summary>
       /// SettableRLSD 属性指明是否可以为该串行端口设置接收线路信号检测(RLSD)(如果支持 RLSD)。
       /// 值: TRUE 或 FALSE。值 TRUE 表示可以设置 RLSD。
       /// </summary>
       public bool SettableRLSD { get; set; }
       /// <summary>
       /// SettableStopBits 属性指明是否可以为该串行端口设置停止位。
       /// 值: TRUE 或 FALSE。值 TRUE 表示可以设置停止位。
       /// </summary>
       public bool SettableStopBits { get; set; }
       public string Status { get; set; }
       /// <summary>
       /// StatusInfo 是一个字符串，指明逻辑设备是处于启用(值 = 3)、禁用(值 = 4)、其他(1)还是未知(2)状态。如果这个属性不适用于逻辑设备，则值应该为 5 (“不适用”)。
       /// </summary>
       public ushort StatusInfo { get; set; }
       /// <summary>
       /// Supports16BitMode 属性指明该串行端口上是否支持 16 位模式。
       /// 值: TRUE 或 FALSE。值 TRUE 表示支持 16 位模式。
       /// </summary>
       public bool Supports16BitMode { get; set; }
       /// <summary>
       /// SupportsDTRDSR 属性指明该串行端口上是否支持数据终端就绪(DTR)和数据集就绪(DSR)信号。
       /// 值: TRUE 或 FALSE。值 TRUE 表示支持 DTR 和 DSR 信号。
       /// </summary>
       public bool SupportsDTRDSR { get; set; }
       /// <summary>
       /// SupportsElapsedTimeouts 属性指明该串行端口上是否支持已用时间超时。“已用时间超时”跟踪数据传输之间经过的总时间。
       /// 值: TRUE 或 FALSE。值 TRUE 表示支持已用时间超时。
       /// </summary>
       public bool SupportsElapsedTimeouts { get; set; }
       /// <summary>
       /// SupportsIntTimeouts 属性指明是否支持间隔时间超时。“间隔时间超时”是指每段数据到达之间允许经过的时间。
       /// 值: TRUE 或 FALSE。值 TRUE 表示支持间隔时间超时。
       /// </summary>
       public bool SupportsIntTimeouts { get; set; }
       /// <summary>
       /// SupportsParityCheck 属性指明该串行端口上是否支持奇偶校验检查。
       /// 值: TRUE 或 FALSE。值 TRUE 表示支持奇偶校验检查。
       /// </summary>
       public bool SupportsParityCheck { get; set; }
       /// <summary>
       /// SupportsRLSD 属性指明该串行端口上是否支持接收线路信号检测(RLSD)。
       /// 值: TRUE 或 FALSE。值 TRUE 表示支持 RLSD。
       /// </summary>
       public bool SupportsRLSD { get; set; }
       /// <summary>
       /// SupportsRTSCTS 属性指明该串行端口上是否支持准备发送(RTS)和清除发送(CTS)信号。
       /// 值: TRUE 或 FALSE。值 TRUE 表示支持 RTS 和 CTS 信号。
       /// </summary>
       public bool SupportsRTSCTS { get; set; }
       /// <summary>
       /// SupportsSpecialCharacters 属性指明是否支持串行端口控制字符。这些字符指明的是事件而非数据。这些字符是不可显示的，并由驱动程序设置。这些字符包括 EofChar、ErrorChar、BreakChar、EventChar、XonChar 和 XoffChar。
       /// 值: TRUE 或 FALSE。值 TRUE 表示支持特殊字符。
       /// </summary>
       public bool SupportsSpecialCharacters { get; set; }
       /// <summary>
       /// SupportsXOnXOff 属性指明该串行端口上是否支持 XON/XOFF 流控制。
       /// 值: TRUE 或 FALSE。值 TRUE 表示支持 XON/XOFF。
       /// </summary>
       public bool SupportsXOnXOff { get; set; }
       /// <summary>
       /// SupportsXOnXOffSet 属性指明通信提供程序是否支持配置 XON/XOFF 流控制设置。
       /// 值: TRUE 或 FALSE。值 TRUE 表示支持 XON/XOFF 流控制设置。
       /// </summary>
       public bool SupportsXOnXOffSet { get; set; }
       /// <summary>
       /// 作用域系统的 CreationClassName。
       /// </summary>
       public string SystemCreationClassName { get; set; }
       /// <summary>
       /// 作用域系统的名称。
       /// </summary>
       public string SystemName { get; set; }
       /// <summary>
       /// TimeOfLastReset 属性指明上一次重置此控制器的日期和时间。这可能意味着控制器已断电或被重新初始化。
       /// </summary>
       public DateTime TimeOfLastReset { get; set; }
    }
}
