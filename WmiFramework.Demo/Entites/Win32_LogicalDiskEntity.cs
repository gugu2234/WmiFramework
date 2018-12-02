using System;
using WmiFramework;
namespace WmiFramework.Demo.Entites
{
    /// <summary>
    /// Win32_LogicalDisk 类表示一种数据源，在 Win32 系统上，该数据源可解析到实际的本地存储设备。
    /// 该类既可返回本地磁盘，也可返回映射逻辑磁盘。然而，推荐的方法是将此类用于获取本地磁盘上的信息，而用 Win32_MappedLogicalDisk 类获取映射逻辑磁盘上的信息。
    /// </summary>
   [Classes("Win32_LogicalDisk", @"ROOT\CIMV2")]
    public class Win32_LogicalDiskEntity : EntityBase
    {
       /// <summary>
       /// Access 描述媒体是可读(值 = 1)、可写(值 = 2)、还是可读写(值 = 3)。此外，还可以定义“未知”(0)和“写入一次”(4)。
       /// </summary>
       public ushort Access { get; set; }
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
       /// Compressed 属性指明逻辑卷是否作为一个压缩实体而存在，例如 DoubleSpace 卷。如果支持文件压缩(例如在 NTFS 上)，则此属性为 FALSE。
       /// </summary>
       public bool Compressed { get; set; }
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
       /// DeviceID 属性包含可唯一标识逻辑磁盘的一个字符串，该字符串将逻辑磁盘与系统上的其他设备区分开。
       /// </summary>
       public string DeviceID { get; set; }
       /// <summary>
       /// DriveType 属性包含与此逻辑磁盘所代表的磁盘驱动器类型相应的数值。有关其他值的信息，请参阅 Platform SDK 文档。
       /// 例如: CD-ROM 驱动器会返回 5。
       /// </summary>
       public uint DriveType { get; set; }
       /// <summary>
       /// ErrorCleared 是一个布尔值属性，指明 LastErrorCode 属性中报告的错误现已清除。
       /// </summary>
       public bool ErrorCleared { get; set; }
       /// <summary>
       /// ErrorDescription 是一个自由格式字符串，提供有关 LastErrorCode 属性中记录的错误的详细信息，以及有关可以采取的纠正措施的信息。
       /// </summary>
       public string ErrorDescription { get; set; }
       /// <summary>
       /// ErrorMethodology 是一个自由格式字符串，用于描述此存储盘区所支持的错误检测类型和校正类型。
       /// </summary>
       public string ErrorMethodology { get; set; }
       /// <summary>
       /// FileSystem 属性指明逻辑磁盘上的文件系统。
       /// 例如: NTFS
       /// </summary>
       public string FileSystem { get; set; }
       /// <summary>
       /// FreeSpace 属性指明在逻辑磁盘上有多少可用空间(以字节为单位)。
       /// </summary>
       public ulong FreeSpace { get; set; }
       public DateTime InstallDate { get; set; }
       /// <summary>
       /// LastErrorCode 捕获由逻辑设备报告的最后一个错误代码。
       /// </summary>
       public uint LastErrorCode { get; set; }
       /// <summary>
       /// MaximumComponentLength 属性包含 Win32 驱动器支持的文件名组件的最大长度。文件名组件是两个反斜杠之间的那一部分文件名。此值可用于表示指定的文件系统支持长名称。例如，在支持长名称的 FAT 文件系统中，函数将存储值 255，而不是前面的 8.3 指明器。使用 NTFS 文件系统的系统也支持长名称。
       /// 例如: 255
       /// </summary>
       public uint MaximumComponentLength { get; set; }
       /// <summary>
       /// MediaType 属性指明逻辑驱动器中目前存在的媒体类型。此值是 winioctl.h 中定义的 MEDIA_TYPE 枚举的值之一。
       /// <B>注意:</B> 如果驱动器中当前没有媒体，则可移动驱动器的此值可能不准确。
       /// </summary>
       public uint MediaType { get; set; }
       public string Name { get; set; }
       /// <summary>
       /// 多个连续块的总数量，每块值的大小都包含在 BlockSize 属性中，这构成了此存储盘区。存储盘区的总大小可以通过 BlockSize 属性的值乘以该属性的值计算而来。如果 BlockSize 的值为 1，则该属性即为存储盘区的总大小。
       /// </summary>
       public ulong NumberOfBlocks { get; set; }
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
       /// ProviderName 属性指明逻辑设备的网络路径名称。
       /// </summary>
       public string ProviderName { get; set; }
       /// <summary>
       /// 一个用于描述媒体和/或其用途的自由格式字符串。
       /// </summary>
       public string Purpose { get; set; }
       /// <summary>
       /// QuotasDisabled 属性指明此卷上未启用配额管理。
       /// </summary>
       public bool QuotasDisabled { get; set; }
       /// <summary>
       /// QuotasIncomplete 属性指明曾经使用过配额管理，但现在已禁用。Incomplete 表示在配额管理被禁用后遗留在该文件系统中的信息。
       /// </summary>
       public bool QuotasIncomplete { get; set; }
       /// <summary>
       /// QuotasRebuilding 属性指明一种活动状态，用于表明文件系统正在进行信息编译，并为配额管理设置磁盘。
       /// </summary>
       public bool QuotasRebuilding { get; set; }
       /// <summary>
       /// Size 属性指明逻辑磁盘大小(以字节为单位)。
       /// </summary>
       public ulong Size { get; set; }
       public string Status { get; set; }
       /// <summary>
       /// StatusInfo 是一个字符串，指明逻辑设备是处于启用(值 = 3)、禁用(值 = 4)、其他(1)还是未知(2)状态。如果这个属性不适用于逻辑设备，则值应该为 5 (“不适用”)。
       /// </summary>
       public ushort StatusInfo { get; set; }
       /// <summary>
       /// SupportsDiskQuotas 属性指明该卷是否支持磁盘配额
       /// </summary>
       public bool SupportsDiskQuotas { get; set; }
       /// <summary>
       /// SupportsFileBasedCompression 属性指明逻辑磁盘分区是否支持文件压缩，例如 NTFS 便支持文件压缩。当 Compressed 属性为 TRUE 时，此属性就是 FALSE。
       /// 值: TRUE 或 FALSE。如果是 TRUE，则表示逻辑磁盘支持文件压缩。
       /// </summary>
       public bool SupportsFileBasedCompression { get; set; }
       /// <summary>
       /// 作用域系统的 CreationClassName。
       /// </summary>
       public string SystemCreationClassName { get; set; }
       /// <summary>
       /// 作用域系统的名称。
       /// </summary>
       public string SystemName { get; set; }
       /// <summary>
       /// VolumeDirty 属性指明磁盘在下次引导启动时是否需要运行 chkdsk。该方法仅适用于逻辑磁盘代表机器上的物理磁盘的情况。它不适用于映射逻辑驱动器。
       /// </summary>
       public bool VolumeDirty { get; set; }
       /// <summary>
       /// VolumeName 属性指明逻辑磁盘的卷名。
       /// 限制: 最多 32 个字符
       /// </summary>
       public string VolumeName { get; set; }
       /// <summary>
       /// VolumeSerialNumber 属性指明逻辑磁盘的卷序列号。
       /// 限制: 最多 11 个字符
       /// 例如: A8C3-D032
       /// </summary>
       public string VolumeSerialNumber { get; set; }
    }
}
