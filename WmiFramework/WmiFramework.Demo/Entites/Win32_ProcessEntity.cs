using System;
using WmiFramework;
namespace WmiFramework.Demo.Entites
{
    /// <summary>
    /// Win32_Process 类表示 Win32 系统上的事件序列。包含一个或多个处理器或解释器、某种可执行代码和输入集的任何序列均为此类的附属(或成员)。
    /// 例如: Win32 系统上运行的客户端应用程序。
    /// </summary>
   [Classes("Win32_Process", @"ROOT\CIMV2")]
    public class Win32_ProcessEntity : EntityBase
    {
       public string Caption { get; set; }
       /// <summary>
       /// CommandLine 属性指定启动特定进程使用的命令行(如果适用)。
       /// </summary>
       public string CommandLine { get; set; }
       /// <summary>
       /// CreationClassName 指明创建实例时使用的类或子类的名称。与此类的其他键属性一起使用时，此属性可唯一标识此类及其子类的所有实例。
       /// </summary>
       public string CreationClassName { get; set; }
       /// <summary>
       /// 开始执行进程的时间。
       /// </summary>
       public DateTime CreationDate { get; set; }
       /// <summary>
       /// CSCreationClassName 包含作用域计算机系统的创建类名。
       /// </summary>
       public string CSCreationClassName { get; set; }
       /// <summary>
       /// 作用域计算机系统的名称。
       /// </summary>
       public string CSName { get; set; }
       public string Description { get; set; }
       /// <summary>
       /// ExecutablePath 属性指明进程可执行文件的路径。
       /// 例如: C:\WINDOWS\EXPLORER.EXE
       /// </summary>
       public string ExecutablePath { get; set; }
       /// <summary>
       /// 指明进程当前的运行状况。相关值包含“就绪”(2)、“正在运行”(3)、“已阻止”(4)及其他。
       /// </summary>
       public ushort ExecutionState { get; set; }
       /// <summary>
       /// 用于标识进程的字符串。进程 ID 是一种进程句柄。
       /// </summary>
       public string Handle { get; set; }
       /// <summary>
       /// HandleCount 属性指定此进程当前打开的句柄总数。该数值是此进程中各线程当前打开的句柄总和。句柄用于检查或修改系统资源。每个句柄均在内部维护表中单独占一项。这些项包括资源地址和识别资源类型的方法。
       /// </summary>
       public uint HandleCount { get; set; }
       public DateTime InstallDate { get; set; }
       /// <summary>
       /// 内核模式下的时间(单位: 100 纳秒)。如果该信息不可用，应使用 0 值。
       /// </summary>
       public ulong KernelModeTime { get; set; }
       /// <summary>
       /// MaximumWorkingSetSize 属性指明进程的最大工作集大小。进程的工作集是指物理 RAM 中当前可见的内存页面集。这些页面为常驻页面并可供应用程序使用且不会触发页面错误。
       /// 例如: 1413120。
       /// </summary>
       public uint MaximumWorkingSetSize { get; set; }
       /// <summary>
       /// MinimumWorkingSetSize 属性指明进程的最小工作集大小。进程的工作集是指物理 RAM 中当前可见的内存页面集。这些页面为常驻页面并可供应用程序使用且不会触发页面错误。
       /// 例如: 20480。
       /// </summary>
       public uint MinimumWorkingSetSize { get; set; }
       public string Name { get; set; }
       /// <summary>
       /// 作用域操作系统的创建类名。
       /// </summary>
       public string OSCreationClassName { get; set; }
       /// <summary>
       /// 作用域操作系统的名称。
       /// </summary>
       public string OSName { get; set; }
       /// <summary>
       /// OtherOperationCount 属性指定除读取和写入操作以外执行的 I/O 操作数。
       /// </summary>
       public ulong OtherOperationCount { get; set; }
       /// <summary>
       /// OtherTransferCount 属性指定除读取和写入操作以外的其他操作期间的数据传输量。
       /// </summary>
       public ulong OtherTransferCount { get; set; }
       /// <summary>
       /// PageFaults 属性指明进程生成的页面错误数目。
       /// 例如: 10
       /// </summary>
       public uint PageFaults { get; set; }
       /// <summary>
       /// PageFileUsage 属性指明进程当前使用的页面文件空间量。
       /// 例如: 102435
       /// </summary>
       public uint PageFileUsage { get; set; }
       /// <summary>
       /// ParentProcessId 属性指定创建此进程的进程的唯一标识符。进程标识号可重用，因此标识号仅可识别该进程生命周期内的进程。通过 ParentProcessId 识别的进程可能已经终止，因此 ParentProcessId 不一定表示正在运行的进程。ParentProcessId 还可能误指重用该进程标识符的进程。CreationDate 属性可用于确定创建此进程后是否创建指定的父进程。
       /// </summary>
       public uint ParentProcessId { get; set; }
       /// <summary>
       /// PeakPageFileUsage 属性指明进程在有效期限内使用的最大页面文件空间量。
       /// 例如: 102367
       /// </summary>
       public uint PeakPageFileUsage { get; set; }
       /// <summary>
       /// PeakVirtualSize 属性指定进程在任意时间占用的最大虚拟地址空间。虚拟地址空间用量不一定与磁盘或主内存页用量相对应。但是，虚拟空间有限，如果使用过多，进程加载库的能力可能会受到限制。
       /// </summary>
       public ulong PeakVirtualSize { get; set; }
       /// <summary>
       /// PeakWorkingSetSize 属性指明进程的工作集峰值大小。
       /// 例如: 1413120
       /// </summary>
       public uint PeakWorkingSetSize { get; set; }
       /// <summary>
       /// Priority 属性指明进程在操作系统中的计划优先级。值越高，进程获得的优先级越高。Priority 值的范围介于 0 (优先级最低)到 31 (优先级最高)之间。
       /// 例如: 7。
       /// </summary>
       public uint Priority { get; set; }
       /// <summary>
       /// PrivatePageCount 属性指定分配仅供此进程访问的当前页面数量
       /// </summary>
       public ulong PrivatePageCount { get; set; }
       /// <summary>
       /// ProcessId 属性包含可用于识别进程的全局进程标识符。该值自进程创建开始至进程终止一直有效。
       /// </summary>
       public uint ProcessId { get; set; }
       /// <summary>
       /// QuotaNonPagedPoolUsage 属性指明进程的非分页缓冲池的用量配额。
       /// 例如: 15
       /// </summary>
       public uint QuotaNonPagedPoolUsage { get; set; }
       /// <summary>
       /// QuotaPagedPoolUsage 属性指明进程的分页缓冲池的用量配额。
       /// 例如: 22
       /// </summary>
       public uint QuotaPagedPoolUsage { get; set; }
       /// <summary>
       /// QuotaPeakNonPagedPoolUsage 属性指明进程的非分页缓冲池的用量配额峰值。
       /// 例如: 31
       /// </summary>
       public uint QuotaPeakNonPagedPoolUsage { get; set; }
       /// <summary>
       /// QuotaPeakPagedPoolUsage 属性指明进程的分页缓冲池的用量配额峰值。
       /// 例如: 31
       /// </summary>
       public uint QuotaPeakPagedPoolUsage { get; set; }
       /// <summary>
       /// ReadOperationCount 属性指定执行的读取操作的次数。
       /// </summary>
       public ulong ReadOperationCount { get; set; }
       /// <summary>
       /// ReadTransferCount 属性指定读取的数据量。
       /// </summary>
       public ulong ReadTransferCount { get; set; }
       /// <summary>
       /// SessionId 属性指定创建会话时操作系统生成的惟一标识符。会话时间包括从登录特定系统到注销的完整过程。
       /// </summary>
       public uint SessionId { get; set; }
       public string Status { get; set; }
       /// <summary>
       /// 停止或终止进程的时间。
       /// </summary>
       public DateTime TerminationDate { get; set; }
       /// <summary>
       /// ThreadCount 属性指定此进程中的活动线程数。指令是处理器中的基本执行单位，线程是执行指令的对象。每项运行进程至少包含一个线程。此属性仅适用于运行 Windows NT 的计算机。
       /// </summary>
       public uint ThreadCount { get; set; }
       /// <summary>
       /// 用户模式下的时间(单位: 100 纳秒)。如果该信息不可用，应使用 0 值。
       /// </summary>
       public ulong UserModeTime { get; set; }
       /// <summary>
       /// VirtualSize 属性指定进程当前使用的虚拟地址空间大小(单位: 字节)。虚拟地址空间用量不一定与磁盘或主内存页用量相对应。虚拟空间有限，如果使用过多，进程加载库的能力可能会受到限制。
       /// </summary>
       public ulong VirtualSize { get; set; }
       /// <summary>
       /// WindowsVersion 属性指明当前运行进程的 Windows 版本。
       /// 例如: 4.0
       /// </summary>
       public string WindowsVersion { get; set; }
       /// <summary>
       /// 基于分页内存管理的操作系统有效执行一个进程所需的内存量(以字节为单位)。如果内存不足(< 工作集大小)，则会出现系统失败。如果不知道这个信息，请输入 NULL 或 0。如果已提供此信息，则可以对其进行监视，从而了解随着执行过程的进展，进程对内存需求的不断变化。
       /// </summary>
       public ulong WorkingSetSize { get; set; }
       /// <summary>
       /// WriteOperationCount 属性指定执行的写入操作的次数。
       /// </summary>
       public ulong WriteOperationCount { get; set; }
       /// <summary>
       /// WriteTransferCount 属性指定写入的数据量。
       /// </summary>
       public ulong WriteTransferCount { get; set; }
    }
}
