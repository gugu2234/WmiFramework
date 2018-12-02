using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WmiFramework
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = true)]
    public class ClassesAttribute : Attribute
    {
        public string Name { get; set; }

        public string Scope { get; set; }

        public ClassesAttribute(string name, string scope)
        {
            Name = name;
            Scope = scope;
        }
    }
}
