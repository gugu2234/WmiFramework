using System;
using WmiFramework;
namespace WmiFramework.Demo.Entites
{
    /// <summary>
    /// Win32_MemoryDevice 类表示计算机系统内存设备及其关联的映射地址的属性。
    /// </summary>
   [Classes("Win32_MemoryDevice", @"ROOT\CIMV2")]
    public class Win32_MemoryDeviceEntity : EntityBase
    {
       /// <summary>
       /// Access 描述媒体是可读(值 = 1)、可写(值 = 2)、还是可读写(值 = 3)。此外，还可以定义“未知”(0)和“写入一次”(4)。
       /// </summary>
       public ushort Access { get; set; }
       /// <summary>
       /// AdditionalErrorData 属性包含其他错误信息。例如，ECC 症状，如果使用基于 CRC 的 ErrorMethodology，则会返回检查位。对于后一种情况，如果发现一位错误并且已知 CRC 算法，则可以确定具体出现错误的位。这种类型的数据(ECC 症状、检查位、奇偶校验位数据或供应商提供的其他信息)包含在该字段中。只有在 ErrorInfo 属性不等于 3 时，才使用该属性。
       /// </summary>
       public byte[] AdditionalErrorData { get; set; }
       /// <summary>
       /// 设备的可用性和状态。例如: Availability 属性可以指明设备正在运行并且为全功率(值=3)、或者处于警告(4)、测试(5)、降级(10)或节能状态(值为 13-15 和 17)。有关节能状态，其定义如下所示: 值 13 (“节能 - 未知”)表示设备处于节能模式，但是它在该模式中的准确状态未知；14 (“节能 - 低功耗模式”)表示设备处于节能状态，但仍然正常运转，可能会出现性能下降；15 (“节能 - 待机”)表示设备没有正常运转，但是可以“快速”转入全功率工作状态；值为 17 (“节能 - 警告”)时表示设备虽然处于节能模式，但它的状态是警告状态。
       /// </summary>
       public ushort Availability { get; set; }
       /// <summary>
       /// 构成此 StorageExtent 的块的大小(以字节为单位)。如果块大小可变，则应指定块的最大值；如果块的大小未知，或者块的概念无效(例如，聚合盘区、内存或 LogicalDisk)，请输入 1。
       /// </summary>
       public ulong BlockSize { get; set; }
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
       /// CorrectableError 属性指明是否可以纠正最近的错误。如果 ErrorInfo 设置为 3，则不使用该属性。
       /// 值: TRUE 或 FALSE。如果为 TRUE，则可以纠正该错误。
       /// </summary>
       public bool CorrectableError { get; set; }
       /// <summary>
       /// CreationClassName 指明创建实例时使用的类或子类的名称。与此类的其他键属性一起使用时，此属性可唯一标识此类及其子类的所有实例。
       /// </summary>
       public string CreationClassName { get; set; }
       public string Description { get; set; }
       /// <summary>
       /// DeviceID 属性包含对内存设备进行唯一标识的字符串。
       /// 例如: Memory Device 1
       /// </summary>
       public string DeviceID { get; set; }
       /// <summary>
       /// EndingAddress 属性指定应用程序或操作系统引用的结束地址。该内存地址是内存控制器为该内存对象映射的地址。
       /// </summary>
       public ulong EndingAddress { get; set; }
       /// <summary>
       /// ErrorAccess 属性指明导致上一个错误的内存访问操作。只有在 ErrorInfo 未设置为 3 时，该属性才有效。
       /// </summary>
       public ushort ErrorAccess { get; set; }
       /// <summary>
       /// ErrorAddress 属性指定上一个内存错误的地址。只有在 ErrorInfo 未设置为 3 值时，才使用该属性。
       /// </summary>
       public ulong ErrorAddress { get; set; }
       /// <summary>
       /// ErrorCleared 是一个布尔值属性，指明 LastErrorCode 属性中报告的错误现已清除。
       /// </summary>
       public bool ErrorCleared { get; set; }
       /// <summary>
       /// ErrorData 属性包含上次访问内存并出现错误时捕获的数据。该数据占据数组的前 n 个八位字节，这是保存 ErrorTransferSize 属性指定的位数所必需的。如果 ErrorTransferSize 为 0，则不使用该属性。
       /// </summary>
       public byte[] ErrorData { get; set; }
       /// <summary>
       /// ErrorDataOrder 属性指明 ErrorData 属性中存储的数据的顺序。只有在 ErrorTransferSize 值为 0 时，才使用该属性。
       /// </summary>
       public ushort ErrorDataOrder { get; set; }
       /// <summary>
       /// ErrorDescription 是一个自由格式字符串，提供有关 LastErrorCode 属性中记录的错误的详细信息，以及有关可以采取的纠正措施的信息。
       /// </summary>
       public string ErrorDescription { get; set; }
       /// <summary>
       /// ErrorGranularity 属性指定可解决错误的级别。
       /// 例如: 设备级别。
       /// </summary>
       public ushort ErrorGranularity { get; set; }
       /// <summary>
       /// ErrorInfo 属性包含对最近出现的错误类型进行描述的整数枚举。该属性不使用值 12-14。这些值指明某个错误是否可以纠正，而此信息可以在 CorrectableError 属性中找到。
       /// </summary>
       public ushort ErrorInfo { get; set; }
       /// <summary>
       /// ErrorMethodology 属性指定内存硬件使用的错误检查类型。
       /// </summary>
       public string ErrorMethodology { get; set; }
       /// <summary>
       /// ErrorResolution 属性指定实际确定错误原因的数据量。在 ErrorInfo 属性设置为 3 时，不使用该属性。
       /// </summary>
       public ulong ErrorResolution { get; set; }
       /// <summary>
       /// ErrorTime 属性包含上次出现内存错误的时间。只有在 ErrorInfo 未设置为 3 时，该属性才有效。
       /// </summary>
       public DateTime ErrorTime { get; set; }
       /// <summary>
       /// ErrorTransferSize 属性指定传输的数据(包含上一个错误)大小。如果没有错误，则该属性设置为 0。
       /// </summary>
       public uint ErrorTransferSize { get; set; }
       public DateTime InstallDate { get; set; }
       /// <summary>
       /// LastErrorCode 捕获由逻辑设备报告的最后一个错误代码。
       /// </summary>
       public uint LastErrorCode { get; set; }
       public string Name { get; set; }
       /// <summary>
       /// 多个连续块的总数量，每块值的大小都包含在 BlockSize 属性中，这构成了此存储盘区。存储盘区的总大小可以通过 BlockSize 属性的值乘以该属性的值计算而来。如果 BlockSize 的值为 1，则该属性即为存储盘区的总大小。
       /// </summary>
       public ulong NumberOfBlocks { get; set; }
       /// <summary>
       /// 在 ErrorInfo 属性设置为 1 时，OtherErrorDescription 属性提供更多信息。
       /// </summary>
       public string OtherErrorDescription { get; set; }
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
       /// 一个用于描述媒体和/或其用途的自由格式字符串。
       /// </summary>
       public string Purpose { get; set; }
       /// <summary>
       /// StartingAddress 属性指定应用程序或操作系统引用的起始地址。该内存地址是内存控制器为该内存对象映射的地址。
       /// </summary>
       public ulong StartingAddress { get; set; }
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
       /// SystemLevelAddress 属性指明 ErrorAddress 属性中的地址信息是系统级地址(TRUE)还是物理地址(FALSE)。只有在 ErrorInfo 未设置为 3 时，才使用该属性。
       /// 值: TRUE 或 FALSE。如果为 TRUE，则 ErrorAddress 包含系统级地址。
       /// </summary>
       public bool SystemLevelAddress { get; set; }
       /// <summary>
       /// 作用域系统的名称。
       /// </summary>
       public string SystemName { get; set; }
    }
}
