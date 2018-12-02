using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WmiFramework
{
    /// <summary>
    /// 方法处理器声明属性
    /// 框架会根据此属性自动加载对应方法名处理器
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    class MethodHandlerAttribute : Attribute
    {
        /// <summary>
        /// 方法名
        /// </summary>
        public string Name { get; set; }

        public MethodHandlerAttribute(string name)
        {
            Name = name;
        }
    }
}
