using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using WmiFramework.Assistant.Components;

namespace WmiFramework.Assistant.Models
{
    /// <summary>
    /// WMI属性
    /// </summary>
    public class Property
    {
        /// <summary>
        /// 属性名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        public CimType Type { get; set; }

        /// <summary>
        /// 是否数组
        /// </summary>
        public bool IsArray { get; set; }

        public Property()
        {

        }

        public Property(PropertyData propertyData)
        {
            Name = propertyData.Name;
            Description = propertyData.Qualifiers.GetDescription();
            Type = propertyData.Type;
            IsArray = propertyData.IsArray;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
