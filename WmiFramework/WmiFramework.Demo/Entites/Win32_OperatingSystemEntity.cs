using System;
using WmiFramework;
namespace WmiFramework.Demo.Entites
{
    /// <summary>
    /// Win32_OperatingSystem 类表示安装在 Win32 计算机系统上的操作系统。可安装在 Win32 系统上的任何操作系统均是该类的附属(或成员)。
    /// 例如: Microsoft Windows 95。
    /// </summary>
   [Classes("Win32_OperatingSystem", @"ROOT\CIMV2")]
    public class Win32_OperatingSystemEntity : EntityBase
    {
       /// <summary>
       /// BootDevice 属性指明 Win32 操作系统启动的磁盘驱动器的名称。
       /// 例如: \\Device\Harddisk0。
       /// </summary>
       public string BootDevice { get; set; }
       /// <summary>
       /// BuildNumber 属性指明操作系统的内部版本号。可用于提供比产品发行版本号更精确的版本信息
       /// 例如: 1381
       /// </summary>
       public string BuildNumber { get; set; }
       /// <summary>
       /// BuildType 属性指明操作系统使用的内部版本类型。如零售版本和已检验版本。
       /// </summary>
       public string BuildType { get; set; }
       public string Caption { get; set; }
       /// <summary>
       /// CodeSet 属性指明操作系统使用的代码页值。代码页包含操作系统用于将字符串翻译成不同语言的字符表。美国国家标准学会(ANSI)列出了表示定义的代码页的值。如果操作系统不使用 ANSI 代码页，该成员将被设置为 0。CodeSet 字符串最多可使用六个字符定义代码页值。
       /// 例如: 1255。
       /// </summary>
       public string CodeSet { get; set; }
       /// <summary>
       /// CountryCode 属性指明操作系统使用的国家/地区代码。值基于国际电话拨号前缀(也称为 IBM 国家/地区代码)。CountryCode 字符串最多可使用六个字符定义国家/地区代码值。
       /// 例如: 1 代表美国)
       /// </summary>
       public string CountryCode { get; set; }
       /// <summary>
       /// CreationClassName 指明创建实例时使用的类或子类的名称。与此类的其他键属性一起使用时，此属性可唯一标识此类及其子类的所有实例。
       /// </summary>
       public string CreationClassName { get; set; }
       /// <summary>
       /// CSCreationClassName 包含作用域计算机系统的创建类名。
       /// </summary>
       public string CSCreationClassName { get; set; }
       /// <summary>
       /// CSDVersion 属性包含一个以 null 结束的字符串，用于指明安装在计算机系统上的最新 Service Pack。如未安装 Service Pack，则该字符串为 NULL。对于运行 Windows 95 的计算机系统，此属性包含一个以 null 结束的字符串，用以提供任意操作系统附加信息。
       /// 例如: Service Pack 3。
       /// </summary>
       public string CSDVersion { get; set; }
       /// <summary>
       /// CSName 包含作用域计算机系统的名称。
       /// </summary>
       public string CSName { get; set; }
       /// <summary>
       /// CurrentTimeZone 指明操作系统时间与格林威治标准时间的偏差(以分钟为单位)。该数值可以是正数、负数或零。
       /// </summary>
       public short CurrentTimeZone { get; set; }
       /// <summary>
       /// 如果为 True，表示运行的是 32 位应用程序并应用了数据执行保护(DEP)。(如果 DataExecutionPrevention_Available = false 则该值为 False)
       /// </summary>
       public bool DataExecutionPrevention_32BitApplications { get; set; }
       /// <summary>
       /// 如果为 True，表示该硬件支持 Windows 数据执行保护(DEP)技术。除非内存位置明确包含可执行代码，否则 DEP 应确保所有内存位置均以非可执行属性标记。这样有助于减少某些类型的缓冲区溢出安全漏洞。如果 DEP 可用，64 位应用程序会自动受到保护。要确定是否已为 32 位应用程序和驱动程序启用了 DEP，请使用 DataExecutionPrevention_ 属性
       /// </summary>
       public bool DataExecutionPrevention_Available { get; set; }
       /// <summary>
       /// 如果为 True，表示运行的是驱动程序并应用了数据执行保护(DEP)。(如果 DataExecutionPrevention_Available = false 则该值为 False)
       /// </summary>
       public bool DataExecutionPrevention_Drivers { get; set; }
       /// <summary>
       /// DataExecutionPrevention_SupportPolicy 指明应用四个数据执行保护(DEP)设置中的哪一个。各项设置均会因应用 32 位应用程序的 DEP 的程度不同而有所差异。请注意，DEP 始终应用到 Windows 内核。Always On (不适用于用户界面)表示为计算机上的所有 32 位应用程序(无一例外)均启用 DEP。OptOut 表示默认为所有 32 位应用程序启用 DEP，用户或管理员必须通过将某个 32 位应用程序添加到例外列表来明确删除对其的支持。OptIn 表示只为有限数量的二进制文件(内核和所有 Windows 服务)启用 DEP，但默认情况下，所有 32 位应用程序的 DEP 均处于关闭状态；用户或管理员必须明确选择 AlwaysOn (不适用于用户界面)或 OptOut 设置才能将 DEP 应用到 32 位应用程序。AlwaysOff (不适用于用户界面)表示为计算机上所有 32 位应用程序关闭 DEP。
       /// </summary>
       public byte DataExecutionPrevention_SupportPolicy { get; set; }
       /// <summary>
       /// Debug 属性指明操作系统是否为已检验(调试)版本。已检验版本会提供错误检查、参数验证和系统调试代码。已检验二进制文件中的其他代码还会生成内核调试程序错误消息并进入调试程序。这有助于即时确定错误原因和位置。已检验版本的性能会因执行其他代码而受到影响。
       /// 值: TRUE 或 FALSE，TRUE 值表示已安装调试版本的 User.exe。
       /// </summary>
       public bool Debug { get; set; }
       /// <summary>
       /// Description 属性提供 Windows 操作系统的描述。某些用户界面(允许对这项描述进行编辑的用户界面)限制其长度上限为 48 个字符。
       /// </summary>
       public string Description { get; set; }
       /// <summary>
       /// 布尔值，指明操作系统是否在几个计算机系统节点上进行分发。如果是，则应当将这些节点组合为一个群集。
       /// </summary>
       public bool Distributed { get; set; }
       /// <summary>
       /// EncryptionLevel 属性指定安全交易的加密级别是 40 位、128 位还是 n 位加密。
       /// </summary>
       public uint EncryptionLevel { get; set; }
       /// <summary>
       /// ForegroundApplicationBoost 属性指明前台应用程序优先级提升。在运行 Windows NT 4.0 和 Windows 2000 的计算机系统上，系统通过为应用程序提供更多的执行时间片(量子长度)来扩大应用程序。ForegroundApplicationBoost 值为 0 时，表示系统扩大了 6 个量子长度；如果为 1，则扩大了 12 个量子长度；如果是 2，则扩大了 18 个量子长度。在 Windows NT 3.51 及更早版本上，系统通过提升计划优先级来扩大应用程序。对于这些系统，计划优先级将随该属性值的增加而上升。默认值为 2。
       /// </summary>
       public byte ForegroundApplicationBoost { get; set; }
       /// <summary>
       /// 当前未使用且可用的物理内存大小(以千字节为单位)
       /// </summary>
       public ulong FreePhysicalMemory { get; set; }
       /// <summary>
       /// 能够映射到操作系统的分页文件中，但不会导致其他页被换出的总千字节数。0 表示没有分页文件。
       /// </summary>
       public ulong FreeSpaceInPagingFiles { get; set; }
       /// <summary>
       /// 当前尚未使用并且可用的虚拟内存空间(以 KB 为单位)。例如，此空间大小可以通过计算可用 RAM 空间与可用分页空间之和而获得(即属性、FreePhysicalMemory 和 FreeSpaceInPagingFiles 之和)。
       /// </summary>
       public ulong FreeVirtualMemory { get; set; }
       public DateTime InstallDate { get; set; }
       /// <summary>
       /// LargeSystemCache 属性指明是要优化应用程序内存(value=0)还是系统性能(value=1)。
       /// </summary>
       public uint LargeSystemCache { get; set; }
       /// <summary>
       /// 上次引导操作系统的时间
       /// </summary>
       public DateTime LastBootUpTime { get; set; }
       /// <summary>
       /// 操作系统的本地日期和时间标记。
       /// </summary>
       public DateTime LocalDateTime { get; set; }
       /// <summary>
       /// Locale 属性指明操作系统使用的语言标识符。语言标识符是一个国家或地区的国际标准数字缩写。每种语言均具有唯一语言标识符(LANGID)，该标识符是一种包含主要语言标识符和次要语言标识符的 16 位数值。
       /// </summary>
       public string Locale { get; set; }
       /// <summary>
       /// Manufacturer 属性指明操作系统制造商的名称。对于 Win32 系统，此值将为 Microsoft Corporation。
       /// </summary>
       public string Manufacturer { get; set; }
       /// <summary>
       /// 操作系统可以支持的进程上下文的最大数量。如果没有固定的最大值，则值应该为 0。在有固定最大值的系统上，此对象可以帮助诊断达到最大值时出现的故障。如果未知，请输入 -1。
       /// </summary>
       public uint MaxNumberOfProcesses { get; set; }
       /// <summary>
       /// 可以指派给一个进程的最大内存空间(以 KB 为单位)。对于没有虚拟内存的操作系统，这个值一般来讲等于物理内存空间减去 BIOS 和 OS 使用的内存空间而得到的值。对于某些操作系统，这个值可能无穷大 - 在这种情况下，应该输入 0。对于其他情况，这个值可能是固定的常量 - 例如 2G 或 4G。
       /// </summary>
       public ulong MaxProcessMemorySize { get; set; }
       /// <summary>
       /// MUILanguages 属性指明系统中安装的 MUI 语言。
       /// 例如: en-us。
       /// </summary>
       public string[] MUILanguages { get; set; }
       /// <summary>
       /// 计算机系统中的操作系统实例名称。
       /// </summary>
       public string Name { get; set; }
       /// <summary>
       /// 操作系统的用户许可证数。如果没有限制，请输入 0。如果未知，请输入 -1。
       /// </summary>
       public uint NumberOfLicensedUsers { get; set; }
       /// <summary>
       /// 当前在操作系统上加载或运行的进程上下文数。
       /// </summary>
       public uint NumberOfProcesses { get; set; }
       /// <summary>
       /// 操作系统目前正在为其存储状态信息的用户会话数
       /// </summary>
       public uint NumberOfUsers { get; set; }
       /// <summary>
       /// OperatingSystemSKU 属性指定操作系统的 SKU。
       /// </summary>
       public uint OperatingSystemSKU { get; set; }
       /// <summary>
       /// Organization 属性指明(操作系统)注册用户的公司名称。
       /// 例如: Microsoft Corporation。
       /// </summary>
       public string Organization { get; set; }
       /// <summary>
       /// OSArchitecture 属性指明操作系统体系结构。例如: 32 位/64 位 Intel、64 位 AMD
       /// </summary>
       public string OSArchitecture { get; set; }
       /// <summary>
       /// OSLanguage 属性指明操作系统安装的语言版本。
       /// 例如: 0x0807 (德语，瑞士)
       /// </summary>
       public uint OSLanguage { get; set; }
       /// <summary>
       /// OSProductSuite 属性识别操作系统上安装和许可的系统产品。
       /// </summary>
       public uint OSProductSuite { get; set; }
       /// <summary>
       /// 指明操作系统类型的整数。
       /// </summary>
       public ushort OSType { get; set; }
       /// <summary>
       /// 一个字符串，描述当操作系统属性 OSType 设为 1 (“其他”)时，所使用的制造商和操作系统类型。插入到 OtherTypeDescription 中的字符串的格式应该与为 OSType 定义的 Values 字符串的格式相似。当 OSType 的值不为 1 时，OtherTypeDescription 应该设为 NULL。
       /// </summary>
       public string OtherTypeDescription { get; set; }
       public bool PAEEnabled { get; set; }
       /// <summary>
       /// PlusProductID 属性包含 Windows Plus! 操作系统增强软件(如果已安装)的产品标识号。
       /// </summary>
       public string PlusProductID { get; set; }
       /// <summary>
       /// PlusVersionNumber 属性包含 Windows Plus! 操作系统增强软件(如果安装)的版本号。
       /// </summary>
       public string PlusVersionNumber { get; set; }
       /// <summary>
       /// PortableOperatingSystem 属性指明操作系统是否从受支持的本地连接存储设备启动。
       /// 值: TRUE 或 FALSE，TRUE 值表示该操作系统从支持的本地连接存储设备启动。
       /// 
       /// </summary>
       public bool PortableOperatingSystem { get; set; }
       /// <summary>
       /// Primary 属性决定这是否为主要操作系统。
       /// 值: TRUE 或 FALSE。TRUE 值表示这是主要操作系统。
       /// </summary>
       public bool Primary { get; set; }
       /// <summary>
       /// ProductType 属性指明有关此系统的其他信息。此数字可以是下列值之一:
       /// 1 - 工作站
       /// 2 - 域控制器
       /// 3 - 服务器
       /// </summary>
       public uint ProductType { get; set; }
       /// <summary>
       /// RegisteredUser 属性指明操作系统注册用户的名称。
       /// 例如: Jane Doe
       /// </summary>
       public string RegisteredUser { get; set; }
       /// <summary>
       /// SerialNumber 属性指明操作系统产品序列标识号。
       /// 例如:10497-OEM-0031416-71674。
       /// </summary>
       public string SerialNumber { get; set; }
       /// <summary>
       /// ServicePackMajorVersion 属性指明计算机系统上安装的服务包的主要版本号。如果尚未安装服务包，则该值为零。ServicePackMajorVersion 仅对运行 Windows 2000 及更高版本的计算机有效(否则为 NULL)。
       /// </summary>
       public ushort ServicePackMajorVersion { get; set; }
       /// <summary>
       /// ServicePackMinorVersion 属性指明计算机系统上安装的服务包的次要版本号。如果尚未安装服务包，则该值为零。ServicePackMinorVersion 仅对运行 Windows 2000 及更高版本的计算机有效(否则为 NULL)。
       /// </summary>
       public ushort ServicePackMinorVersion { get; set; }
       /// <summary>
       /// 可以存储在操作系统的分页文件中的总千字节数。注意，此数值不代表磁盘上分页文件的实际物理大小。0 表示没有分页文件。
       /// </summary>
       public ulong SizeStoredInPagingFiles { get; set; }
       public string Status { get; set; }
       /// <summary>
       /// SuiteMask 属性指明一组位标志，用于识别系统上提供的产品套件。此数字可以是下列值的组合:
       /// 0 - Windows Server 2003，小型企业版
       /// 1 - Windows Server 2003，企业版
       /// 2 - Windows Server 2003，Backoffice 版
       /// 3 - Windows Server 2003，Communications 版
       /// 4 - Microsoft Terminal Services 
       /// 5 - Windows Server 2003，小型企业受限版
       /// 6 - Windows XP Embedded 
       /// 7 - Windows Server 2003，数据中心版
       /// 8 - 单用户
       /// 9 - Windows XP 家庭版
       /// 10 - Windows Server 2003，Web 版
       /// </summary>
       public uint SuiteMask { get; set; }
       /// <summary>
       /// SystemDevice 属性指明安装操作系统的物理磁盘分区。
       /// </summary>
       public string SystemDevice { get; set; }
       /// <summary>
       /// SystemDirectory 属性指明操作系统的系统目录。
       /// 例如: C:\WINDOWS\SYSTEM32
       /// </summary>
       public string SystemDirectory { get; set; }
       /// <summary>
       /// SystemDrive 属性包含操作系统所在的磁盘驱动器号。
       /// 例如: C:
       /// </summary>
       public string SystemDrive { get; set; }
       /// <summary>
       /// 总交换空间(以 KB 为单位)。如果交换空间没有与页面文件区分开来，这个值可能为 NULL (未指定)。但是，有些操作系统会对这两个概念进行区分。例如，在 UNIX 中，当可用页面列表数量减少并长时间低于某个指定数量时，所有进程都可以被“换出”。
       /// </summary>
       public ulong TotalSwapSpaceSize { get; set; }
       /// <summary>
       /// 虚拟内存空间(以 KB 为单位)。例如，这可以通过将 RAM 总量与分页空间数量相加(即计算机系统的内存量与属性 SizeStoredInPagingFiles 之和)获得。
       /// </summary>
       public ulong TotalVirtualMemorySize { get; set; }
       /// <summary>
       /// 操作系统中可用的物理内存总量(以 KB 为单位)。该值并不一定表示真实的物理内存总量，而是报告给操作系统的可用内存量。
       /// </summary>
       public ulong TotalVisibleMemorySize { get; set; }
       /// <summary>
       /// Version 属性指明操作系统的版本号。
       /// 例如: 4.0
       /// </summary>
       public string Version { get; set; }
       /// <summary>
       /// WindowsDirectory 属性指明操作系统的 Windows 目录。
       /// 例如: C:\WINDOWS
       /// </summary>
       public string WindowsDirectory { get; set; }
    }
}
