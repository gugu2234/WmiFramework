using System;
using System.Management;
using WmiFramework;
namespace WmiFramework.Demo.Services
{
    /// <summary>
    /// Win32_BIOS 类表示安装在计算机上的计算机系统的基本输入/输出服务(BIOS)的属性。
    /// </summary>
    public class Win32_BIOS : WMIService<Entites.Win32_BIOSEntity>
    {
        public Win32_BIOS(ConnectionOptions options, string address) : base(options, address) { }
    }
}
