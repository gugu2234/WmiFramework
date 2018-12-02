using System;
using System.Management;
using WmiFramework;
namespace WmiFramework.Demo.Services
{
    /// <summary>
    /// Win32_UserDesktop 类表示用户帐户与其特定的桌面设置之间的关联。
    /// </summary>
    public class Win32_UserDesktop : WMIService<Entites.Win32_UserDesktopEntity>
    {
        public Win32_UserDesktop(ConnectionOptions options, string address) : base(options, address) { }
    }
}
