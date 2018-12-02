using System;
using WmiFramework;
namespace WmiFramework.Demo.Entites
{
    /// <summary>
    /// Win32_Processor 类表示能够解释 Win32 计算机系统上一系列计算机指令的设备。在多处理器计算机上，对应于每个处理器都有一个该类的实例。
    /// </summary>
   [Classes("Win32_Processor", @"ROOT\CIMV2")]
    public class Win32_ProcessorEntity : EntityBase
    {
       /// <summary>
       /// 处理器地址宽度(以位为单位)。
       /// </summary>
       public ushort AddressWidth { get; set; }
       /// <summary>
       /// Architecture 属性指定此平台所使用的处理器体系结构。它返回下列整数值之一:
       /// 0 - x86 
       /// 1 - MIPS 
       /// 2 - Alpha 
       /// 3 - PowerPC 
       /// 6 - ia64 
       /// 9 - x64 
       /// 
       /// </summary>
       public ushort Architecture { get; set; }
       /// <summary>
       /// 此处理器的资源标记的字符串编号
       /// </summary>
       public string AssetTag { get; set; }
       /// <summary>
       /// 设备的可用性和状态。例如: Availability 属性可以指明设备正在运行并且为全功率(值=3)、或者处于警告(4)、测试(5)、降级(10)或节能状态(值为 13-15 和 17)。有关节能状态，其定义如下所示: 值 13 (“节能 - 未知”)表示设备处于节能模式，但是它在该模式中的准确状态未知；14 (“节能 - 低功耗模式”)表示设备处于节能状态，但仍然正常运转，可能会出现性能下降；15 (“节能 - 待机”)表示设备没有正常运转，但是可以“快速”转入全功率工作状态；值为 17 (“节能 - 警告”)时表示设备虽然处于节能模式，但它的状态是警告状态。
       /// </summary>
       public ushort Availability { get; set; }
       public string Caption { get; set; }
       /// <summary>
       /// 定义处理器支持的功能。
       /// </summary>
       public uint Characteristics { get; set; }
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
       /// CpuStatus 属性指定处理器的当前状态。此状态随着处理器使用情况的变化而更改，而不因处理器物理状况的变化而更改。
       /// </summary>
       public ushort CpuStatus { get; set; }
       /// <summary>
       /// CreationClassName 指明创建实例时使用的类或子类的名称。与此类的其他键属性一起使用时，此属性可唯一标识此类及其子类的所有实例。
       /// </summary>
       public string CreationClassName { get; set; }
       /// <summary>
       /// 该处理器的当前速度(以兆赫为单位)。
       /// </summary>
       public uint CurrentClockSpeed { get; set; }
       /// <summary>
       /// CurrentVoltage 指定处理器的电压。该字段的 0 至 6 位包含处理器当前电压乘以 10 得出的值。仅当 SMBIOS 指定电压值时才设置此值。有关具体的电压值，请参阅 VoltageCaps。
       /// 例如: 对应处理器电压 1.8 伏特的字段值应为 92h = 80h + (1.8 x 10) = 80h + 18 = 80h + 12h。
       /// </summary>
       public ushort CurrentVoltage { get; set; }
       /// <summary>
       /// 处理器数据宽度(以位为单位)。
       /// </summary>
       public ushort DataWidth { get; set; }
       public string Description { get; set; }
       /// <summary>
       /// DeviceID 属性包含可唯一标识处理器的一个字符串，此字符串将该处理器与系统上的其他设备区分开。
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
       /// ExtClock 属性指定外部时钟频率。如果该频率未知，则将此属性设置为 Null。
       /// </summary>
       public uint ExtClock { get; set; }
       /// <summary>
       /// 处理器系列类型。例如，值包括“支持 MMX(TM) 技术的英特尔(R) 奔腾(R) 处理器”(14) 和 "68040" (96)。
       /// </summary>
       public ushort Family { get; set; }
       public DateTime InstallDate { get; set; }
       /// <summary>
       /// L2CacheSize 属性指定处理器的第 2 级缓存的大小。第 2 级缓存是一个外部内存区域，其访问速度比主要 RAM 内存更快。
       /// </summary>
       public uint L2CacheSize { get; set; }
       /// <summary>
       /// L2CacheSpeed 属性指定处理器的第 2 级缓存的时钟速度。第 2 级缓存是一个外部内存区域，其访问速度比主要 RAM 内存更快。
       /// </summary>
       public uint L2CacheSpeed { get; set; }
       /// <summary>
       /// L3CacheSize 属性指定处理器的第 3 级缓存的大小。第 3 级缓存是一个外部内存区域，其访问速度比主要 RAM 内存更快。
       /// </summary>
       public uint L3CacheSize { get; set; }
       /// <summary>
       /// L3CacheSpeed 属性指定处理器的第 3 级缓存的时钟速度。第 3 级缓存是一个外部内存区域，其访问速度比主要 RAM 内存更快。
       /// </summary>
       public uint L3CacheSpeed { get; set; }
       /// <summary>
       /// LastErrorCode 捕获由逻辑设备报告的最后一个错误代码。
       /// </summary>
       public uint LastErrorCode { get; set; }
       /// <summary>
       /// Level 属性进一步定义处理器类型。此值取决于处理器的体系结构。
       /// </summary>
       public ushort Level { get; set; }
       /// <summary>
       /// LoadPercentage 属性指定每个处理器在最后一秒钟内的平均负载容量。“处理器负载”这个术语指每个处理器同时所承担的计算总量。
       /// </summary>
       public ushort LoadPercentage { get; set; }
       /// <summary>
       /// Manufacturer 属性指定处理器制造商的名称。
       /// 例如: GenuineSilicon
       /// </summary>
       public string Manufacturer { get; set; }
       /// <summary>
       /// 该处理器的最大速度(以兆赫为单位)。
       /// </summary>
       public uint MaxClockSpeed { get; set; }
       public string Name { get; set; }
       /// <summary>
       /// NumberOfCores 属性包含处理器的总核心数，例如双核计算机的此属性为 NumberOfCores = 2。
       /// </summary>
       public uint NumberOfCores { get; set; }
       /// <summary>
       /// 每个处理器插槽的已启用核心数。
       /// </summary>
       public uint NumberOfEnabledCore { get; set; }
       /// <summary>
       /// NumberOfLogicalProcessors 属性指定逻辑处理器的总数。
       /// </summary>
       public uint NumberOfLogicalProcessors { get; set; }
       /// <summary>
       /// 描述处理器系列类型的字符串，当处理器系列属性设置为 1 (“其他”)时，将使用该字符串。如果处理器系列属性的值不是 1，则应将该字符串设置为 NULL。
       /// </summary>
       public string OtherFamilyDescription { get; set; }
       /// <summary>
       /// 此处理器的部件号的字符串编号。此值由制造商设置，通常不可更改。
       /// </summary>
       public string PartNumber { get; set; }
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
       /// ProcessorId 属性包含描述处理器功能的处理器特定信息。对于 x86 类 CPU，该字段的格式取决于处理器是否支持 CPUID 指令。如果支持该指令，则 ProcessorId 属性包含两个 DWORD 格式的值。第一个值(偏移量 08h-0Bh)是 CPUID 指令返回的 EAX 值，输入 EAX 设为 1。第二个值(偏移量 0Ch-0Fh)是该指令返回的 EDX 值。只有 ProcessorID 属性的前两个字节有意义(其他字节均设为 0)，它们含有 CPU 重置时的 DX 注册表内容(格式为 WORD)。
       /// </summary>
       public string ProcessorId { get; set; }
       /// <summary>
       /// ProcessorType 属性指定处理器的主要功能。
       /// </summary>
       public ushort ProcessorType { get; set; }
       /// <summary>
       /// Revision 属性指定系统中依赖于体系结构的修订级别。此值的含义取决于处理器的体系结构。此属性包含的值与“版本”成员的值相同，但使用数字格式。
       /// </summary>
       public ushort Revision { get; set; }
       /// <summary>
       /// 一个用于描述处理器角色的自由格式字符串，例如:“中央处理器”或“数学处理器”
       /// </summary>
       public string Role { get; set; }
       /// <summary>
       /// SecondLevelAddressTranslationExtensions 属性确定处理器是否支持用于虚拟化的地址转换扩展。
       /// </summary>
       public bool SecondLevelAddressTranslationExtensions { get; set; }
       /// <summary>
       /// 此处理器的序列号字符串编号。此值由制造商设置，通常不可更改。
       /// </summary>
       public string SerialNumber { get; set; }
       /// <summary>
       /// SocketDesignation 属性包含在电路上使用的芯片插槽类型。
       /// 例如: J202
       /// </summary>
       public string SocketDesignation { get; set; }
       public string Status { get; set; }
       /// <summary>
       /// StatusInfo 是一个字符串，指明逻辑设备是处于启用(值 = 3)、禁用(值 = 4)、其他(1)还是未知(2)状态。如果这个属性不适用于逻辑设备，则值应该为 5 (“不适用”)。
       /// </summary>
       public ushort StatusInfo { get; set; }
       /// <summary>
       /// Stepping 是一个自由格式字符串，指明处理器系列中处理器的修订级别。
       /// </summary>
       public string Stepping { get; set; }
       /// <summary>
       /// 作用域系统的 CreationClassName。
       /// </summary>
       public string SystemCreationClassName { get; set; }
       /// <summary>
       /// 作用域系统的名称。
       /// </summary>
       public string SystemName { get; set; }
       /// <summary>
       /// 每个处理器插槽的线程数。
       /// </summary>
       public uint ThreadCount { get; set; }
       /// <summary>
       /// 处理器的全局唯一标识符。这个标识符可能只在一个处理器系列中是唯一的。
       /// </summary>
       public string UniqueId { get; set; }
       /// <summary>
       /// CPU 插槽信息，其中包括如何升级此处理器(如果支持升级)的相关数据。该属性是一个整数枚举类型。
       /// </summary>
       public ushort UpgradeMethod { get; set; }
       /// <summary>
       /// Version 属性指定依赖于体系结构的处理器的修订号。注意: 在 Windows 95 中不使用此成员。
       /// 例如: 型号 2，步进 12。
       /// </summary>
       public string Version { get; set; }
       /// <summary>
       /// VirtualizationFirmwareEnabled 属性确定固件是否启用了虚拟化扩展。
       /// </summary>
       public bool VirtualizationFirmwareEnabled { get; set; }
       /// <summary>
       /// VMMonitorModeExtensions 属性确定处理器是否支持 Intel 或 AMD 虚拟机监控程序扩展。
       /// </summary>
       public bool VMMonitorModeExtensions { get; set; }
       /// <summary>
       /// VoltageCaps 属性指定处理器的电压容量。该字段的第 0 至 3 位表示处理器插槽能接受的具体电压。所有其他位应设为零。如果要设置多个位，则可以配置插槽。有关电压范围的信息，请参阅 CurrentVoltage。如果该属性为 NULL，则表示电压容量未知。
       /// </summary>
       public uint VoltageCaps { get; set; }
    }
}
