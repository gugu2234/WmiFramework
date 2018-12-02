using System;
using WmiFramework;
namespace WmiFramework.Demo.Entites
{
    /// <summary>
    /// Win32_UserDesktop 类表示用户帐户与其特定的桌面设置之间的关联。
    /// </summary>
   [Classes("Win32_UserDesktop", @"ROOT\CIMV2")]
    public class Win32_UserDesktopEntity : EntityBase
    {
       /// <summary>
       /// Element 引用表示其桌面可通过此类的 Settings 属性自定义的用户帐户。
       /// </summary>
       public short Element { get; set; }
       /// <summary>
       /// Setting 引用表示用于自定义某个特定用户帐户桌面的桌面设置。
       /// </summary>
       public short Setting { get; set; }
    }
}
