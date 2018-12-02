using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using WmiFramework.Assistant.Components;

namespace WmiFramework.Assistant.Models
{
    /// <summary>
    /// WMI类
    /// </summary>
    public class Classes
    {
        /// <summary>
        /// 类名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 属性
        /// </summary>
        public Property[] Properties { get; set; }

        /// <summary>
        /// 方法
        /// </summary>
        public Method[] Methods { get; set; }

        public Classes()
        {

        }

        public Classes(ManagementClass obj)
        {
            Namespace = obj.ClassPath.NamespacePath;
            Name = obj.ClassPath.ClassName;
            Description = obj.Qualifiers.GetDescription();
            Properties = obj.Properties.ToEnumerable<PropertyData>().Select(c => new Property(c)).ToArray();
            Methods = obj.Methods.ToEnumerable<MethodData>().Select(c => new Method(c)).ToArray();
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is Classes classes && classes.Namespace.Equals(this.Namespace) && classes.Name.Equals(this.Name);
        }
    }
}
