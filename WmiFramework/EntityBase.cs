using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;

namespace WmiFramework
{
    public abstract class EntityBase
    {
        internal ManagementObject BaseObject { get; set; }
    }
}
