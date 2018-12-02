using System;
using WmiFramework;
namespace WmiFramework.Demo.Entites
{
    /// <summary>
    /// Win32_ComputerSystem 类表示在 Win32 环境中运行的计算机系统。
    /// </summary>
   [Classes("Win32_ComputerSystem", @"ROOT\CIMV2")]
    public class Win32_ComputerSystemEntity : EntityBase
    {
       /// <summary>
       /// AdminPasswordStatus 属性指明管理员密码状态的系统范围硬件安全设置。
       /// </summary>
       public ushort AdminPasswordStatus { get; set; }
       /// <summary>
       /// AutomaticManagedPagefile 属性确定是否启用系统管理的页面文件。在 Windows Server 2003、XP 及更低版本上不提供此功能。
       /// 值: TRUE 或 FALSE。如果值为 TRUE，则表示已启用自动管理页面文件。
       /// </summary>
       public bool AutomaticManagedPagefile { get; set; }
       /// <summary>
       /// AutomaticResetBootOption 属性确定是否启用自动重置启动选项，即系统出现故障后，计算机是否尝试重新引导。
       /// 值: TRUE 或 FALSE。如果值为 TRUE，则表示已启用自动重置启动选项。
       /// </summary>
       public bool AutomaticResetBootOption { get; set; }
       /// <summary>
       /// AutomaticResetCapability 属性确定此计算机上是否可以使用自动重新引导功能。此功能在 Windows NT 上可用，但在 Windows 95 上不可用。
       /// 值: TRUE 或 FALSE。如果值为 TRUE，则表示已启用自动重置。
       /// </summary>
       public bool AutomaticResetCapability { get; set; }
       /// <summary>
       /// 启动选项限制，指明达到重置限制时应采取的系统操作。
       /// </summary>
       public ushort BootOptionOnLimit { get; set; }
       /// <summary>
       /// BootOptionOnWatchDog 属性指明在超过监视器计时器上的时间后应采取的重新启动操作类型。
       /// </summary>
       public ushort BootOptionOnWatchDog { get; set; }
       /// <summary>
       /// BootROMSupported 属性确定是否支持引导 ROM。
       /// 值为 TRUE 或 FALSE。如果 BootROMSupported 为 TRUE，则支持引导 ROM。
       /// </summary>
       public bool BootROMSupported { get; set; }
       /// <summary>
       /// 用于标识启动状态的“状态”和“其他数据”字段
       /// </summary>
       public ushort[] BootStatus { get; set; }
       /// <summary>
       /// BootupState 属性指定系统的启动方式。防故障引导(也称为安全引导)忽略用户的启动文件。
       /// 限制: 必须具备一个值。
       /// </summary>
       public string BootupState { get; set; }
       public string Caption { get; set; }
       /// <summary>
       /// ChassisBootupState 属性指明机箱的启动状态。
       /// </summary>
       public ushort ChassisBootupState { get; set; }
       /// <summary>
       /// 以 null 结束的字符串编号，用于描述机箱或外壳 SKU 编号
       /// </summary>
       public string ChassisSKUNumber { get; set; }
       /// <summary>
       /// CreationClassName 指明创建实例过程中所使用的类或子类的名称。与此类的其他键属性一起使用时，该属性可以唯一标识此类及其子类的所有实例。
       /// </summary>
       public string CreationClassName { get; set; }
       /// <summary>
       /// CurrentTimeZone 属性指明单一计算机系统与协调世界时相差的时间量。
       /// </summary>
       public short CurrentTimeZone { get; set; }
       /// <summary>
       /// DaylightInEffect 属性指定夏令时是否生效。
       /// 值: TRUE 或 FALSE。如果值为 TRUE，则表示当前使用夏令时。在大多数情况下，这意味着当前时间比标准时间早 1 小时。
       /// </summary>
       public bool DaylightInEffect { get; set; }
       public string Description { get; set; }
       /// <summary>
       /// DNSHostName 属性指明本地计算机的 DNS 主机名。
       /// </summary>
       public string DNSHostName { get; set; }
       /// <summary>
       /// Domain 属性指明计算机所属的域的名称。
       /// </summary>
       public string Domain { get; set; }
       /// <summary>
       /// DomainRole 属性指明此计算机在其指定的域-工作组中所充当的角色。域-工作组是同一网络上的一组计算机。例如，DomainRole 属性可能显示这台计算机是“成员工作站”(值为 [1])。
       /// </summary>
       public ushort DomainRole { get; set; }
       /// <summary>
       /// EnableDaylightSavingsTime 属性指明此计算机是否识别夏令时。FALSE - 本年内不会将时间向前或向后调整 1 小时。NULL - 此系统上 DST(夏令时)的状态未知
       /// </summary>
       public bool EnableDaylightSavingsTime { get; set; }
       /// <summary>
       /// FrontPanelResetStatus 属性指明计算机上重置按钮的硬件安全设置。
       /// </summary>
       public ushort FrontPanelResetStatus { get; set; }
       /// <summary>
       /// HypervisorPresent 属性确定系统是否在符合行业标准惯例的虚拟机监控程序下运行，以此来报告是否存在虚拟机监控程序。
       /// 值: TRUE 或 FALSE。如果为 TRUE，则表示存在虚拟机监控程序。
       /// </summary>
       public bool HypervisorPresent { get; set; }
       /// <summary>
       /// InfraredSupported 属性确定计算机系统上是否存在红外(IR)端口。
       /// 值为 TRUE 或 FALSE。如果 InfraredSupported 为 TRUE，则表示存在红外端口。
       /// </summary>
       public bool InfraredSupported { get; set; }
       /// <summary>
       /// 此对象包含查找初始加载设备(它的键)或引导服务(以申请启动操作系统)所需的数据。另外，还可以指定加载参数(即路径名和参数)。
       /// </summary>
       public string[] InitialLoadInfo { get; set; }
       public DateTime InstallDate { get; set; }
       /// <summary>
       /// KeyboardPasswordStatus 属性指明键盘密码状态的系统范围硬件安全设置。
       /// </summary>
       public ushort KeyboardPasswordStatus { get; set; }
       /// <summary>
       /// 此对象包含的数据可以识别初始加载设备(它的键)或上次加载操作系统时请求的引导服务。另外，还可以指定加载参数(即路径名和参数)。
       /// </summary>
       public string LastLoadInfo { get; set; }
       /// <summary>
       /// Manufacturer 属性指明计算机制造商的名称。
       /// 例如: Acme
       /// </summary>
       public string Manufacturer { get; set; }
       /// <summary>
       /// Model 属性指明由制造商提供的计算机产品名称。
       /// </summary>
       public string Model { get; set; }
       /// <summary>
       /// Name 属性定义用于识别对象的名称标签。在派生子类时，Name 属性可以替代为 Key 属性。
       /// </summary>
       public string Name { get; set; }
       /// <summary>
       /// CIM_ComputerSystem 对象及其派生对象是 CIM 的顶层对象。它们为众多组件提供作用域。要求具备唯一的 CIM_System 键。可以定义启发式来创建 CIM_ComputerSystem 名称，以尝试始终生成与发现协议无关的相同名称。在多次发现同一资源或实体，并且无法将其解析为一个对象的情况下，它可以防止出现清单和管理问题。虽然使用启发式是一个可选项，但是建议采用。
       /// 
       /// NameFormat 属性通过启发式来标识生成计算机系统名称的方式。在 CIM V2 常见模式规范中，详细介绍了启发式。它假定按顺序遍历文档记录的规则，以确定和指派名称。NameFormat 值列表定义了指派计算机系统名称时的优先级顺序。几个规则均可映射到相同的值。
       /// 
       /// 注意，使用启发式计算的 CIM_ComputerSystem 名称为系统的关键值。使用别名，可以为 CIM_ComputerSystem 指定并使用其他更适合的名称。
       /// </summary>
       public string NameFormat { get; set; }
       /// <summary>
       /// NetworkServerModeEnabled 属性确定是否已启用网络服务器模式。
       /// 值: TRUE 或 FALSE。如果值为 TRUE，则表示已启用网络服务器模式。
       /// </summary>
       public bool NetworkServerModeEnabled { get; set; }
       /// <summary>
       /// NumberOfLogicalProcessors 属性指明系统上当前可用的逻辑处理器数量。
       /// </summary>
       public uint NumberOfLogicalProcessors { get; set; }
       /// <summary>
       /// NumberOfProcessors 属性指明系统上当前可用的物理处理器的数量。这是状态为“已启用”的处理器的数量，与计算机系统的处理器数量相对。前者可通过使用 Win32_ComputerSystemProcessor 关联枚举与计算机系统对象关联的处理器实例数量来确定。
       /// </summary>
       public uint NumberOfProcessors { get; set; }
       /// <summary>
       /// OEMLogoBitmap 数组用于为 OEM 创建的位图保存数据。
       /// </summary>
       public byte[] OEMLogoBitmap { get; set; }
       /// <summary>
       /// 此结构包含 OEM 定义的自由格式字符串。例如: 系统参考文档的商品编号和制造商的联系信息等。
       /// </summary>
       public string[] OEMStringArray { get; set; }
       /// <summary>
       /// PartOfDomain 属性指明计算机是属于域还是工作组。如果值为 TRUE，则表示计算机属于域。如果值为 FALSE，则表示计算机属于工作组。如果值为 NULL，则表示计算机不属于任何网络组，或计算机所属状态未知。
       /// </summary>
       public bool PartOfDomain { get; set; }
       /// <summary>
       /// PauseAfterReset 属性指明在开始重新引导之前的延迟时间。在系统电源重启、系统重置(本地或远程)以及系统自动重置后使用此属性。值 -1 表示延迟值未知
       /// </summary>
       public long PauseAfterReset { get; set; }
       /// <summary>
       /// PCSystemType 属性指明用户所使用的电脑的性质，例如笔记本电脑、台式计算机或平板电脑等。
       /// </summary>
       public ushort PCSystemType { get; set; }
       public ushort PCSystemTypeEx { get; set; }
       /// <summary>
       /// 指明计算机系统及其关联且正在运行的操作系统中与电源有关的特定功能。值 0=“未知”、1=“不支持”、2=“已禁用” 代表的含义一目了然。值 3=“已启用”表示当前已启用电源管理功能，但是具体的功能集未知或者信息无效。“自动进入节能模式”(4)表示系统可根据用途或其他条件更改其电源状态。“可设置电源状态”(5)表示支持 SetPowerState 方法。“支持电源重启”(6)表示可以通过将 PowerState 参数设置为 5 (“电源重启”)来调用 SetPowerState 方法。“支持定时通电”(7)表示可以通过将 PowerState 参数设置为 5 (“电源重启”)、Time 参数设置为具体的通电日期和时间或间隔，调用 SetPowerState 方法。
       /// </summary>
       public ushort[] PowerManagementCapabilities { get; set; }
       /// <summary>
       /// 布尔值，指明 ComputerSystem 及其运行的 OperatingSystem 是否支持电源管理。该布尔值并不表示当前启用了电源管理功能；或者，如果启用了电源管理功能，该布尔值也不表示具体支持什么功能。相关信息，请参阅 PowerManagementCapabilities 数组。如果该布尔值为 False，那么在 PowerManagementCapabilities 数组中，整数值为 1 的字符串“不支持”应是仅有的条目。
       /// </summary>
       public bool PowerManagementSupported { get; set; }
       /// <summary>
       /// PowerOnPasswordStatus 属性指明开机密码状态的系统范围硬件安全设置。
       /// </summary>
       public ushort PowerOnPasswordStatus { get; set; }
       /// <summary>
       /// 指明计算机系统及其相关操作系统的当前电源状态。关于各种节能状态，其定义如下所示: 值 4 (未知)表示系统处于节能模式，但其具体状态未知；2 (低功耗模式)表示系统处于节能状态，但仍然正常运转，可能会出现性能下降；3 (待机)表示系统没有正常运转，但是可以快速转入全功率工作状态；值 7 (警告)表示计算机系统虽然处于节能模式，但它的状态是警告状态。
       /// </summary>
       public ushort PowerState { get; set; }
       /// <summary>
       /// PowerSupplyState 指明上一次启动时机箱的电源状态。
       /// </summary>
       public ushort PowerSupplyState { get; set; }
       /// <summary>
       /// 一个字符串，提供主要系统所有者的联系信息(如电话号码、电子邮件地址等)。
       /// </summary>
       public string PrimaryOwnerContact { get; set; }
       /// <summary>
       /// 主系统所有者的名称。
       /// </summary>
       public string PrimaryOwnerName { get; set; }
       /// <summary>
       /// 如果已启用(值 = 4)，该单一的计算机系统则可以通过硬件(如电源和重置按钮)进行初始化。如果禁用(值 = 3)，则不允许硬件重置。除了“已启用”和“禁用”之外，还可以定义属性的其他值 -“未实现”(5)、“其他”(1)和“未知”(2)。
       /// </summary>
       public ushort ResetCapability { get; set; }
       /// <summary>
       /// ResetCount 属性指明上次有意重置后自动重置的次数。值 -1 表示此计数未知。
       /// </summary>
       public short ResetCount { get; set; }
       /// <summary>
       /// ResetLimit 属性指明连续尝试系统重置的次数。值 -1 表示此限制未知
       /// </summary>
       public short ResetLimit { get; set; }
       /// <summary>
       /// 一列(组)字符串，用于指定该系统在 IT 环境中的角色。该系统的子类可以覆盖此属性以定义显式 Roles 值。另一方面，工作组可以为指定 Roles 而提供启发式、惯例和指导说明。例如，对于一个网络系统实例，Roles 属性可能会包含字符串“Switch”或“Bridge”。
       /// </summary>
       public string[] Roles { get; set; }
       public string Status { get; set; }
       /// <summary>
       /// SupportContactDescription 属性是一个数组，指明 Win32 计算机系统的支持联系信息。
       /// </summary>
       public string[] SupportContactDescription { get; set; }
       /// <summary>
       /// 此文本字符串标识特定计算机所属的系列。系列是指从硬件或软件角度看，具有类似性但并不完全相同的一组计算机
       /// </summary>
       public string SystemFamily { get; set; }
       /// <summary>
       /// 此文本字符串标识要销售的特定计算机配置。有时它也称为产品 ID 或采购订单号
       /// </summary>
       public string SystemSKUNumber { get; set; }
       /// <summary>
       /// SystemStartupDelay 属性指明启动操作系统前的延迟时间
       /// 
       /// 注意: 在 IA64 位计算机上需要 SE_SYSTEM_ENVIRONMENT 权限。在 32 位系统上不需要此权限。
       /// </summary>
       public ushort SystemStartupDelay { get; set; }
       /// <summary>
       /// SystemStartupOptions 属性数组指明用于启动计算机系统的选项。注意，此属性在 IA64 位计算机上不可写入。
       /// 限制: 必须具备一个值。
       /// 
       /// 注意: 在 IA64 位计算机上需要 SE_SYSTEM_ENVIRONMENT 权限。在其他系统上不需要此权限。
       /// </summary>
       public string[] SystemStartupOptions { get; set; }
       /// <summary>
       /// SystemStartupSetting 属性指明默认启动配置文件的索引。此值通过特意“计算”，通常会返回零(0)，原因是在写入时，配置文件字符串会以物理方式被移动到列表的最上方。(Windows NT 利用此方法确定哪个值是默认值。)
       /// 
       /// 注意: 在 IA64 位计算机上需要 SE_SYSTEM_ENVIRONMENT 权限。在 32 位系统上不需要此权限。
       /// </summary>
       public byte SystemStartupSetting { get; set; }
       /// <summary>
       /// SystemType 属性指明在 Win32 计算机上运行的系统的类型。
       /// 限制: 必须具备一个值
       /// </summary>
       public string SystemType { get; set; }
       /// <summary>
       /// ThermalState 属性指示上次引导时的机箱温度状态。
       /// </summary>
       public ushort ThermalState { get; set; }
       /// <summary>
       /// TotalPhysicalMemory 属性指明物理内存的总大小。
       /// 例如: 67108864
       /// </summary>
       public ulong TotalPhysicalMemory { get; set; }
       /// <summary>
       /// UserName 属性指明当前登录用户的名称。
       /// 限制: 必须具备一个值。
       /// 例如: johnsmith
       /// </summary>
       public string UserName { get; set; }
       /// <summary>
       /// WakeUpType 属性指明导致系统通电启动的事件。
       /// </summary>
       public ushort WakeUpType { get; set; }
       /// <summary>
       /// Workgroup 属性包含工作组名称。仅当 PartOfDomain 属性的值为 FALSE 时，此值才有效。
       /// </summary>
       public string Workgroup { get; set; }
    }
}
