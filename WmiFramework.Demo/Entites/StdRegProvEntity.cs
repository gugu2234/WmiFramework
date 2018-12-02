using System;
using WmiFramework;
namespace WmiFramework.Demo.Entites
{
    /// <summary>
    /// StdRegProv 类包含用于与系统注册表交互的方法。可以将这些方法用于: 
    /// 验证用户的访问权限 
    /// 创建、枚举和删除注册表项 
    /// 创建、枚举和删除命名值 
    /// 读取、写入和删除数据值 
    /// </summary>
   [Classes("StdRegProv", @"ROOT\CIMV2")]
    public class StdRegProvEntity : EntityBase
    {
    }
}
