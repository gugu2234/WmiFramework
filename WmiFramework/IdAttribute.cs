using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WmiFramework
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class IdAttribute : Attribute
    {
    }
}
