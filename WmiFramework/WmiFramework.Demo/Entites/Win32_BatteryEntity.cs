using System;
using WmiFramework;
namespace WmiFramework.Demo.Entites
{
    /// <summary>
    /// Win32_Battery 类表示连接到计算机系统的电池。该类适用于笔记本电脑系统的电池及其他内部/外部电池。
    /// </summary>
   [Classes("Win32_Battery", @"ROOT\CIMV2")]
    public class Win32_BatteryEntity : EntityBase
    {
       /// <summary>
       /// 设备的可用性和状态。例如: Availability 属性可以指明设备正在运行并且为全功率(值=3)、或者处于警告(4)、测试(5)、降级(10)或节能状态(值为 13-15 和 17)。有关节能状态，其定义如下所示: 值 13 (“节能 - 未知”)表示设备处于节能模式，但是它在该模式中的准确状态未知；14 (“节能 - 低功耗模式”)表示设备处于节能状态，但仍然正常运转，可能会出现性能下降；15 (“节能 - 待机”)表示设备没有正常运转，但是可以“快速”转入全功率工作状态；值为 17 (“节能 - 警告”)时表示设备虽然处于节能模式，但它的状态是警告状态。
       /// </summary>
       public ushort Availability { get; set; }
       /// <summary>
       /// BatteryRechargeTime 属性指明电池充满电所需的时间。
       /// BatteryRechargeTime 属性已经被弃用。该属性没有替换值，并且现已被认为过时。
       /// </summary>
       public uint BatteryRechargeTime { get; set; }
       /// <summary>
       /// 描述电池的充电状态。可以指定“电量已满”(值=3)或“电量未满”(值=11)。值 10 在 CIM 架构中无效，因为在 DMI 中，该值表示未安装电池。对于这种情况，此对象不应该实例化。
       /// </summary>
       public ushort BatteryStatus { get; set; }
       public string Caption { get; set; }
       /// <summary>
       /// 一个枚举，用于描述电池的化学特性。
       /// </summary>
       public ushort Chemistry { get; set; }
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
       /// 电池的设计容量(以毫瓦/小时为单位)。如果不支持此属性，请输入 0。
       /// </summary>
       public uint DesignCapacity { get; set; }
       /// <summary>
       /// 电池的设计电压(以毫伏为单位)。如果不支持此属性，请输入 0。
       /// </summary>
       public ulong DesignVoltage { get; set; }
       /// <summary>
       /// DeviceID 属性包含对电池进行标识的字符串。
       /// 例如: Internal Battery
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
       /// <summary>
       /// 估计剩余电量占总电量的百分比。
       /// </summary>
       public ushort EstimatedChargeRemaining { get; set; }
       /// <summary>
       /// EstimatedRunTime 是指在电源关闭、断电并一直停电，或者笔记本电脑与电源断开连接时，当前负载状况下电池电量消耗殆尽所需的大致时间，单位为分钟。
       /// </summary>
       public uint EstimatedRunTime { get; set; }
       /// <summary>
       /// ExpectedBatteryLife 属性指明在充满电后电池电量完全耗尽所需的时间。
       /// ExpectedBatteryLife 属性已经被弃用。该属性没有替换值，并且现已被认为过时。
       /// </summary>
       public uint ExpectedBatteryLife { get; set; }
       /// <summary>
       /// 指明在已充满电的情况下，电池的预期寿命(以分钟为单位)。此属性代表电池的总预期寿命，而不是目前所剩的寿命，后者由 EstimatedRunTime 属性表示。 
       /// </summary>
       public uint ExpectedLife { get; set; }
       /// <summary>
       /// 电池充满电后的容量(以毫瓦/小时为单位)。将此值与 DesignCapacity 属性进行比较可以确定电池何时需要更换。电池的使用寿命通常在 FullChargeCapacity 属性跌至 DesignCapacity 属性的 80% 以下时结束。如果不支持此属性，请输入 0。
       /// </summary>
       public uint FullChargeCapacity { get; set; }
       public DateTime InstallDate { get; set; }
       /// <summary>
       /// LastErrorCode 捕获由逻辑设备报告的最后一个错误代码。
       /// </summary>
       public uint LastErrorCode { get; set; }
       /// <summary>
       /// MaxRechargeTime 指明将电池充满电所需的最长时间(以分钟为单位)。此属性表示将电量耗尽的电池重新充满电所需的时间，而不是目前所剩的充电时间，后者由 TimeToFullCharge 属性表示。 
       /// </summary>
       public uint MaxRechargeTime { get; set; }
       public string Name { get; set; }
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
       /// 此电池支持的智能电池数据规格版本号。如果电池不支持该功能，值应该保留为空。
       /// </summary>
       public string SmartBatteryVersion { get; set; }
       public string Status { get; set; }
       /// <summary>
       /// StatusInfo 是一个字符串，指明逻辑设备是处于启用(值 = 3)、禁用(值 = 4)、其他(1)还是未知(2)状态。如果这个属性不适用于逻辑设备，则值应该为 5 (“不适用”)。
       /// </summary>
       public ushort StatusInfo { get; set; }
       /// <summary>
       /// 作用域系统的 CreationClassName。
       /// </summary>
       public string SystemCreationClassName { get; set; }
       /// <summary>
       /// 作用域系统的名称。
       /// </summary>
       public string SystemName { get; set; }
       /// <summary>
       /// TimeOnBattery 指明自从计算机系统的 UPS 上次切换为电池电源后经过的时间，或自从系统或 UPS 上次重新启动后经过的时间(以较少的时间为准)，单位为秒。如果电池为“联机”，则返回零值。
       /// </summary>
       public uint TimeOnBattery { get; set; }
       /// <summary>
       /// 在当前的充电速度和使用情况下，要将电池充满电所需的剩余时间(以分钟为单位)。
       /// </summary>
       public uint TimeToFullCharge { get; set; }
    }
}
