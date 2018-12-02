using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Management;
using System.Reflection;
using System.Text;

namespace WmiFramework
{
    public class WMIService<T> : IQueryable<T> where T : new()
    {
        private IQueryable<T> query;
        private ConnectionOptions options;
        private string address;

        protected string ClassesName { get; private set; }

        protected string ScopePath { get; private set; }

        public WMIService()
        {
            var classesAttribute = typeof(T).GetCustomAttributes(typeof(ClassesAttribute), true);
            if (classesAttribute.Length < 1)
                throw new InvalidOperationException();
            ClassesName = ((ClassesAttribute)classesAttribute[0]).Name;
            ScopePath = ((ClassesAttribute)classesAttribute[0]).Scope;
            query = new Query<T>(options, address);
        }

        public WMIService(ConnectionOptions options, string address) : this()
        {
            this.options = options;
            this.address = address;
        }

        public Expression Expression => query.Expression;

        public Type ElementType => query.ElementType;

        public IQueryProvider Provider => query.Provider;

        protected ManagementScope GetScope()
        {
            string path = ScopePath;
            if (path[0] != '\\')
                path = "\\" + path;
            var socps = options == null ? new ManagementScope(path) : new ManagementScope(string.Format(@"\\{0}{1}", address, path), options);
            socps.Connect();
            if (!socps.IsConnected)
                throw new ManagementException("连接失败");
            return socps;
        }

        protected ManagementClass GetClass()
        {
            var options = new ObjectGetOptions(null, System.TimeSpan.MaxValue, true);
            var scope = GetScope();
            return new ManagementClass(scope, new ManagementPath(ClassesName), options);
        }

        /// <summary>
        /// WMI值转C#值
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        protected object WmiValueToNet(CimType type, object value)
        {
            switch (type)
            {
                case CimType.Boolean:
                    return bool.Parse(value.ToString());
                case CimType.Char16:
                    return char.Parse(value.ToString());
                case CimType.DateTime:
                    return ManagementDateTimeConverter.ToDateTime(value.ToString());
                case CimType.None:
                    return null;
                case CimType.Object:
                    return value;
                case CimType.Real32:
                    return float.Parse(value.ToString());
                case CimType.Real64:
                    return double.Parse(value.ToString());
                case CimType.Reference:
                    return short.Parse(value.ToString());
                case CimType.SInt16:
                    return short.Parse(value.ToString());
                case CimType.SInt32:
                    return int.Parse(value.ToString());
                case CimType.SInt64:
                    return long.Parse(value.ToString());
                case CimType.SInt8:
                    return sbyte.Parse(value.ToString());
                case CimType.String:
                    return value.ToString();
                case CimType.UInt16:
                    return ushort.Parse(value.ToString());
                case CimType.UInt32:
                    return uint.Parse(value.ToString());
                case CimType.UInt64:
                    return ulong.Parse(value.ToString());
                case CimType.UInt8:
                    return byte.Parse(value.ToString());
                default:
                    return value;
            }
        }

        /// <summary>
        /// C#值转WMI值
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        protected object NetValueToWmi(CimType type, object value)
        {
            switch (type)
            {
                case CimType.DateTime:
                    return ManagementDateTimeConverter.ToDmtfDateTime((DateTime)value);
                default:
                    return value;
            }
        }

        /// <summary>
        /// 获取实体对应WMI对象
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        protected ManagementObject GetEntityWmiObjecj(T entity)
        {
            if (!(entity is EntityBase))
                throw new InvalidOperationException("不支持的实体");
            return (entity as EntityBase).BaseObject;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return query.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return query.GetEnumerator();
        }
    }
}
