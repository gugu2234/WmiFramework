using System;
using WmiFramework;
namespace WmiFramework.Demo.Entites
{
    /// <summary>
    /// Win32_DiskDrive 类表示运行 Win32 操作系统的计算机中显示的物理磁盘驱动器。Win32 物理磁盘驱动器的任何接口都是此类的附属(或成员)。通过此对象显示的磁盘驱动器功能与驱动器的逻辑和管理特性相应。在某些情况下，这可能并不反映设备的实际物理特性。任何基于其他逻辑设备的对象都不会是此类的成员。
    /// 例如: IDE 固定磁盘
    /// </summary>
   [Classes("Win32_DiskDrive", @"ROOT\CIMV2")]
    public class Win32_DiskDriveEntity : EntityBase
    {
       /// <summary>
       /// 设备的可用性和状态。例如: Availability 属性可以指明设备正在运行并且为全功率(值=3)、或者处于警告(4)、测试(5)、降级(10)或节能状态(值为 13-15 和 17)。有关节能状态，其定义如下所示: 值 13 (“节能 - 未知”)表示设备处于节能模式，但是它在该模式中的准确状态未知；14 (“节能 - 低功耗模式”)表示设备处于节能状态，但仍然正常运转，可能会出现性能下降；15 (“节能 - 待机”)表示设备没有正常运转，但是可以“快速”转入全功率工作状态；值为 17 (“节能 - 警告”)时表示设备虽然处于节能模式，但它的状态是警告状态。
       /// </summary>
       public ushort Availability { get; set; }
       /// <summary>
       /// BytesPerSector 属性指明物理磁盘驱动器上每个扇区中的字节数。
       /// 例如: 512
       /// </summary>
       public uint BytesPerSector { get; set; }
       /// <summary>
       /// 媒体访问设备的能力。例如，设备可以支持“随机访问”、可移动媒体和“自动清理”。在这种情况下，数值 3、7 和 9 将被写入数组。
       /// 下列枚举的一些数值需要进行说明: 1) 值 11，“支持双面媒体”，需要区分两种不同的设备: 一种设备是能够访问双面媒体的两个面；另一种设备是只能读取一个面，然后要求将媒体翻转过来再读另一面。2) 值 12，“不需要预卸除弹出”，表示在通过 PickerElement 访问媒体之前，媒体无需从设备中显式弹出。
       /// </summary>
       public ushort[] Capabilities { get; set; }
       /// <summary>
       /// 一个自由格式字符串，用于为“功能”数组中指出的任何访问设备功能提供更为详细的解释。请注意: 此数组的每一项都与“功能”数组中具有相同索引的项目关联。
       /// </summary>
       public string[] CapabilityDescriptions { get; set; }
       public string Caption { get; set; }
       /// <summary>
       /// 一个自由格式字符串，指明设备用以支持压缩的算法或工具。如果无法或不打算描述压缩模式(可能是由于未知的原因)，则建议使用下列词语:“未知”表示不了解设备是否支持压缩功能；“已压缩”表示设备支持压缩功能，但不了解或未透露其压缩模式；“不压缩”表示设备不支持压缩功能。
       /// </summary>
       public string CompressionMethod { get; set; }
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
       /// <summary>
       /// 该设备的默认块大小(以字节为单位)。
       /// </summary>
       public ulong DefaultBlockSize { get; set; }
       public string Description { get; set; }
       /// <summary>
       /// DeviceID 包含可唯一标识磁盘驱动器的一个字符串，该字符串将磁盘驱动器与系统上的其他设备区分开。
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
       /// ErrorMethodology 是一个自由格式字符串，用于描述此设备所支持的错误检测类型和校正类型。
       /// </summary>
       public string ErrorMethodology { get; set; }
       /// <summary>
       /// Firmware Revision 属性是由制造商分配的一个编号，用于标识物理媒体。 
       /// </summary>
       public string FirmwareRevision { get; set; }
       /// <summary>
       /// Index 属性指明某个指定驱动器的物理驱动器号。此成员由 Get Drive Map Info 输入。值 0xFF 表示该驱动器没有映射到物理驱动器。
       /// 例如: 1
       /// </summary>
       public uint Index { get; set; }
       public DateTime InstallDate { get; set; }
       /// <summary>
       /// InterfaceType 属性指明物理磁盘驱动器的接口类型。
       /// 例如: SCSI
       /// </summary>
       public string InterfaceType { get; set; }
       /// <summary>
       /// LastErrorCode 捕获由逻辑设备报告的最后一个错误代码。
       /// </summary>
       public uint LastErrorCode { get; set; }
       /// <summary>
       /// Manufacturer 属性指明磁盘驱动器制造商的名称。
       /// 例如: Seagate
       /// </summary>
       public string Manufacturer { get; set; }
       /// <summary>
       /// 该设备访问的媒体的最大块大小(以字节为单位)。
       /// </summary>
       public ulong MaxBlockSize { get; set; }
       /// <summary>
       /// 该设备所支持媒体的最大容量(以 KB 为单位)。这里所说的 KB 是指将字节数乘以 1000 得出的数值(不是将字节数乘以 1024 获得的结果)。
       /// </summary>
       public ulong MaxMediaSize { get; set; }
       /// <summary>
       /// MediaLoaded 属性确定磁盘驱动器的媒体是否加载。对于固定磁盘驱动器，此属性永远为 TRUE 
       /// 值: TRUE 或 FALSE。如果是 TRUE，则表示媒体已加载。
       /// </summary>
       public bool MediaLoaded { get; set; }
       /// <summary>
       /// MediaType 属性是此设备使用或访问的媒体种类。
       /// 例如: 可移动媒体
       /// </summary>
       public string MediaType { get; set; }
       /// <summary>
       /// 该设备访问的媒体的最小块大小(以字节为单位)。
       /// </summary>
       public ulong MinBlockSize { get; set; }
       /// <summary>
       /// Model 属性指明制造商分配给磁盘驱动器的型号。
       /// 例如: ST32171W
       /// </summary>
       public string Model { get; set; }
       public string Name { get; set; }
       /// <summary>
       /// 布尔值，指明媒体访问设备是否需要清理。“功能”数组属性会显示出是手动还是自动清理。 
       /// </summary>
       public bool NeedsCleaning { get; set; }
       /// <summary>
       /// 当媒体访问设备支持多个单独的媒体时，此属性定义了可支持或插入的最大媒体数量。
       /// </summary>
       public uint NumberOfMediaSupported { get; set; }
       /// <summary>
       /// Partitions 属性指明操作系统在此物理磁盘驱动器上识别的分区数。
       /// 例如: 2
       /// </summary>
       public uint Partitions { get; set; }
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
       /// SCSIBus 属性指明磁盘驱动器的 SCSI 总线编号。
       /// 例如: 0
       /// </summary>
       public uint SCSIBus { get; set; }
       /// <summary>
       /// SCSILogicalUnit 属性指明磁盘驱动器的 SCSI 逻辑单元号(LUN)。
       /// 例如: 0
       /// </summary>
       public ushort SCSILogicalUnit { get; set; }
       /// <summary>
       /// SCSIPort 属性指明磁盘驱动器的 SCSI 端口号。
       /// 例如: 0
       /// </summary>
       public ushort SCSIPort { get; set; }
       /// <summary>
       /// SCSITargetId 属性指明磁盘驱动器的 SCSI ID 号。
       /// 例如: 0
       /// </summary>
       public ushort SCSITargetId { get; set; }
       /// <summary>
       /// SectorsPerTrack 属性指明此物理磁盘驱动器的每个磁道的扇区数。
       /// 例如: 63
       /// </summary>
       public uint SectorsPerTrack { get; set; }
       /// <summary>
       /// Serial number 属性是由制造商分配的一个编号，用于标识物理媒体。
       /// 例如: WD-WM3493798728 即是一个磁盘序列号。
       /// </summary>
       public string SerialNumber { get; set; }
       /// <summary>
       /// Signature 属性用于标识磁盘。它可用于标识共享资源。
       /// </summary>
       public uint Signature { get; set; }
       /// <summary>
       /// Size 属性指明磁盘驱动器的大小。计算方法是将柱面总数、每个柱面中的磁道数、每个磁道中的扇面数和每个扇面中的字节数相乘。
       /// </summary>
       public ulong Size { get; set; }
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
       /// TotalCylinders 属性指明物理磁盘驱动器上的柱面总数。注意: 此属性的值是通过 BIOS 中断 13h 的扩展函数而得到。如果驱动器使用转换方法来支持高容量磁盘，则该值可能不准确。有关准确的驱动器规格，请咨询制造商。
       /// 例如: 657
       /// </summary>
       public ulong TotalCylinders { get; set; }
       /// <summary>
       /// TotalHeads 属性指明磁盘驱动器上的磁头总数。注意: 此属性的值是通过 BIOS 中断 13h 的扩展函数而得到。如果驱动器使用转换方法来支持高容量磁盘，则该值可能不准确。有关准确的驱动器规格，请咨询制造商。
       /// </summary>
       public uint TotalHeads { get; set; }
       /// <summary>
       /// TotalSectors 属性指明物理磁盘驱动器上的扇面总数。注意: 此属性的值是通过 BIOS 中断 13h 的扩展函数而得到。如果驱动器使用转换方法来支持高容量磁盘，则该值可能不准确。有关准确的驱动器规格，请咨询制造商。
       /// 例如: 2649024
       /// </summary>
       public ulong TotalSectors { get; set; }
       /// <summary>
       /// TotalTracks 属性指明物理磁盘驱动器上的磁道总数。注意:此属性的值是通过 BIOS 中断 13h 的扩展函数而得到。如果驱动器使用转换方法来支持高容量磁盘，则该值可能不准确。有关准确的驱动器规格，请咨询制造商。
       /// 例如: 42048
       /// </summary>
       public ulong TotalTracks { get; set; }
       /// <summary>
       /// TracksPerCylinder 属性指明物理磁盘驱动器上每个柱面中磁道的数量。注意: 此属性的值是通过 BIOS 中断 13h 的扩展函数而得到。如果驱动器使用转换方法来支持高容量磁盘，则该值可能不准确。有关准确的驱动器规格，请咨询制造商。
       /// 例如: 64
       /// </summary>
       public uint TracksPerCylinder { get; set; }
    }
}
