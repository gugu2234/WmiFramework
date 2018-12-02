using System;
using WmiFramework;
namespace WmiFramework.Demo.Entites
{
    /// <summary>
    /// Win32_BIOS 类表示安装在计算机上的计算机系统的基本输入/输出服务(BIOS)的属性。
    /// </summary>
   [Classes("Win32_BIOS", @"ROOT\CIMV2")]
    public class Win32_BIOSEntity : EntityBase
    {
       /// <summary>
       /// BiosCharacteristics 属性指定系统支持的 BIOS 特征，如系统管理 BIOS 参考规格中所定义
       /// </summary>
       public ushort[] BiosCharacteristics { get; set; }
       /// <summary>
       /// BIOSVersion 数组属性包含完整的系统 BIOS 信息。许多计算机的注册表中可存储多个版本字符串用以表示系统 BIOS 信息。该属性包含完整的 BIOS 信息集合。
       /// </summary>
       public string[] BIOSVersion { get; set; }
       /// <summary>
       /// 此次编译该软件元素的内部标识符。
       /// </summary>
       public string BuildNumber { get; set; }
       public string Caption { get; set; }
       /// <summary>
       /// 该软件元素使用的编码集。 
       /// </summary>
       public string CodeSet { get; set; }
       /// <summary>
       /// CurrentLanguage 属性显示当前 BIOS 语言的名称。
       /// </summary>
       public string CurrentLanguage { get; set; }
       public string Description { get; set; }
       /// <summary>
       /// 标识嵌入式控制器固件的主要版本。
       /// </summary>
       public byte EmbeddedControllerMajorVersion { get; set; }
       /// <summary>
       /// 标识嵌入式控制器固件的次要版本。
       /// </summary>
       public byte EmbeddedControllerMinorVersion { get; set; }
       /// <summary>
       ///  此属性的值为该软件元素制造商的标识符，通常为库存单位(SKU)编号或商品编号。
       /// </summary>
       public string IdentificationCode { get; set; }
       /// <summary>
       /// InstallableLanguages 属性指明可供在此系统上安装的语言数目。语言可能决定属性，如 Unicode 和双向文本需求。
       /// </summary>
       public ushort InstallableLanguages { get; set; }
       public DateTime InstallDate { get; set; }
       /// <summary>
       /// 此属性的值可以标识该软件元素的语言版本，应使用 ISO 639 中定义的语言编码。在软件元素表示产品的多语言版本或国际版本的位置，应使用多语言字符串。
       /// </summary>
       public string LanguageEdition { get; set; }
       /// <summary>
       /// ListOfLanguages 属性包含可用的 BIOS 可安装语言名称列表。
       /// </summary>
       public string[] ListOfLanguages { get; set; }
       /// <summary>
       /// 该软件元素的制造商
       /// </summary>
       public string Manufacturer { get; set; }
       /// <summary>
       /// 用于标识该软件元素的名称
       /// </summary>
       public string Name { get; set; }
       /// <summary>
       ///  OtherTargetOS 属性在 TargetOperatingSystem 属性值为 1 (“其他”)时会记录软件元素的制造商和操作系统类型，因此当 TargetOperatingSystem 属性的值为“其他”时，OtherTargetOS 属性必须有一个非空值。对于 TargetOperatingSystem 的其他值，OtherTargetOS 属性将为 NULL。 
       /// </summary>
       public string OtherTargetOS { get; set; }
       /// <summary>
       /// 如果为 true，则是计算机系统的主 BIOS。
       /// </summary>
       public bool PrimaryBIOS { get; set; }
       /// <summary>
       /// ReleaseDate 属性指明以协调世界时(UTC)的 YYYYMMDDHHMMSS.MMMMMM(+-)OOO 格式显示的 Win32 BIOS 的发行日期。
       /// </summary>
       public DateTime ReleaseDate { get; set; }
       /// <summary>
       /// 为该软件元素分配的序列号。
       /// </summary>
       public string SerialNumber { get; set; }
       /// <summary>
       /// SMBIOSBIOSVersion 属性包含 SMBIOS 报告的 BIOS 版本。
       /// </summary>
       public string SMBIOSBIOSVersion { get; set; }
       /// <summary>
       /// SMBIOSMajorVersion 属性包含 SMBIOS 主要版本号。如果找不到 SMBIOS，该属性将为 NULL。
       /// </summary>
       public ushort SMBIOSMajorVersion { get; set; }
       /// <summary>
       /// SMBIOSMinorVersion 属性包含 SMBIOS 次要版本号。如果找不到 SMBIOS，该属性将为 NULL。
       /// </summary>
       public ushort SMBIOSMinorVersion { get; set; }
       /// <summary>
       /// SMBIOSPresent 属性指明此计算机系统上是否提供 SMBIOS。
       /// 值: TRUE 或 FALSE。如果设置为 TRUE，说明此计算机上提供 SMBIOS。
       /// </summary>
       public bool SMBIOSPresent { get; set; }
       /// <summary>
       ///  这是该软件元素的标识符，其设计目的是与其他键一起使用，以便创建此 CIM_SoftwareElement 的唯一表示。
       /// </summary>
       public string SoftwareElementID { get; set; }
       /// <summary>
       ///  在此模型中定义 SoftwareElementState 的目的是为了识别软件元素生命周期中的不同状态。- 可部署状态下的软件元素描述了成功对其进行分配所需的详细信息以及创建可安装状态(即下一个状态)的软件元素所需的详细信息(条件和操作)。 - 可安装状态下的软件元素描述了成功对其进行安装所需的详细信息以及创建可执行状态(即下一个状态)的软件元素所需的详细信息(条件和操作)。- 可执行状态下的软件元素描述了成功对其进行启动所需的详细信息以及创建运行状态(即下一个状态)的软件元素所需的详细信息(条件和操作)。 - 运行状态下的软件元素描述了监控和操作开始元素所需的详细信息。
       /// </summary>
       public ushort SoftwareElementState { get; set; }
       public string Status { get; set; }
       /// <summary>
       /// 标识系统 BIOS 的主要版本。
       /// </summary>
       public byte SystemBiosMajorVersion { get; set; }
       /// <summary>
       /// 标识系统 BIOS 的次要版本。
       /// </summary>
       public byte SystemBiosMinorVersion { get; set; }
       /// <summary>
       /// TargetOperatingSystem 属性允许提供程序指定操作系统的环境。此属性的值并不能确保二进制的可执行性，需要另外两份信息。首先，OS 的版本需要通过 OS 版本检查来指定。第二份信息是运行 OS 的体系结构。有了这两份信息，提供程序就能明确识别某个特定软件元素所需的 OS 级别。
       /// </summary>
       public ushort TargetOperatingSystem { get; set; }
       /// <summary>
       /// Version 属性包含 BIOS 版本。此字符串由 BIOS 制造商创建。
       /// </summary>
       public string Version { get; set; }
    }
}
