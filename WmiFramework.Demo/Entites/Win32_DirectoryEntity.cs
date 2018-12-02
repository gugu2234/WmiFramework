using System;
using WmiFramework;
namespace WmiFramework.Demo.Entites
{
    /// <summary>
    /// Win32_Directory 类用于表示 Win32 计算机系统上的目录项。目录是一种文件类型，用于通过逻辑方式对“包含”在其中的数据文件进行分组并为分组文件提供路径信息。
    /// 例如: C:\TEMP。
    /// </summary>
   [Classes("Win32_Directory", @"ROOT\CIMV2")]
    public class Win32_DirectoryEntity : EntityBase
    {
       public uint AccessMask { get; set; }
       public bool Archive { get; set; }
       public string Caption { get; set; }
       public bool Compressed { get; set; }
       public string CompressionMethod { get; set; }
       public string CreationClassName { get; set; }
       public DateTime CreationDate { get; set; }
       public string CSCreationClassName { get; set; }
       public string CSName { get; set; }
       public string Description { get; set; }
       public string Drive { get; set; }
       public string EightDotThreeFileName { get; set; }
       public bool Encrypted { get; set; }
       public string EncryptionMethod { get; set; }
       public string Extension { get; set; }
       public string FileName { get; set; }
       public ulong FileSize { get; set; }
       public string FileType { get; set; }
       public string FSCreationClassName { get; set; }
       public string FSName { get; set; }
       public bool Hidden { get; set; }
       public DateTime InstallDate { get; set; }
       public ulong InUseCount { get; set; }
       public DateTime LastAccessed { get; set; }
       public DateTime LastModified { get; set; }
       public string Name { get; set; }
       public string Path { get; set; }
       public bool Readable { get; set; }
       public string Status { get; set; }
       public bool System { get; set; }
       public bool Writeable { get; set; }
    }
}
