using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using WmiFramework.Assistant.Components;

namespace WmiFramework.Assistant.Models
{
    public class Method
    {
        private Property[] mInParameters;
        private Property[] mOutParameters;

        /// <summary>
        /// 属性名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 输入参数
        /// </summary>
        public Property[] InParameters
        {
            get
            {
                return mInParameters;
            }

            set
            {
                mInParameters = value == null ? new Property[0] : value;
            }
        }

        /// <summary>
        /// 输出参数
        /// </summary>
        public Property[] OutParameters
        {
            get
            {
                return mOutParameters;
            }

            set
            {
                mOutParameters = value == null ? new Property[0] : value;
            }
        }

        public Method()
        {

        }

        public Method(MethodData method)
        {
            Name = method.Name;
            Description = method.Qualifiers.GetDescription();
            InParameters = method.InParameters?.Properties.ToEnumerable<PropertyData>().Select(c => new Property(c)).ToArray();
            OutParameters = method.OutParameters?.Properties.ToEnumerable<PropertyData>().Select(c => new Property(c)).ToArray();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
