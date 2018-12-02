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
    class Context
    {
        private Dictionary<string, IMethodHandler> methodHandlerSet;
        private static Dictionary<string, Type> methodHandlerTypeSet;
        private static Dictionary<Type, ClassesAttribute> entityClassesMap;
        private ConnectionOptions options;
        private string address;

        /// <summary>
        /// WMI类
        /// </summary>
        public ClassesAttribute Classes { get; private set; }

        /// <summary>
        /// 条件限定
        /// </summary>
        public string Where { get; set; }

        /// <summary>
        /// 结果集处理器
        /// </summary>
        public List<IResultHandler> ResultHandlers { get; private set; }

        static Context()
        {
            entityClassesMap = new Dictionary<Type, ClassesAttribute>();
            methodHandlerTypeSet = new Dictionary<string, Type>();
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (var type in assembly.GetTypes())
                {
                    //获取方法处理器
                    if (type.GetInterfaces().Contains(typeof(IMethodHandler)))
                    {
                        var objs = type.GetCustomAttributes(typeof(MethodHandlerAttribute), false);
                        if (objs.Length >= 1)
                        {
                            var obj = (MethodHandlerAttribute)objs[0];
                            methodHandlerTypeSet[obj.Name] = type;
                        }
                    }

                    //获取实体与WMI类映射
                    var classesAttr = type.GetCustomAttributes(typeof(ClassesAttribute), false);
                    if (classesAttr.Length > 0)
                    {
                        entityClassesMap[type] = ((ClassesAttribute)classesAttr.First());
                    }
                }
            }
        }

        public Context(ConnectionOptions options, string address)
        {
            this.options = options;
            this.address = address;
            methodHandlerSet = new Dictionary<string, IMethodHandler>();
            ResultHandlers = new List<IResultHandler>();
        }

        private ManagementScope GetScope(string path)
        {
            if (path[0] != '\\')
                path = "\\" + path;
            var socps = options == null ? new ManagementScope(path) : new ManagementScope(string.Format(@"\\{0}{1}", address, path), options);
            socps.Connect();
            if (!socps.IsConnected)
                throw new ManagementException("连接失败");
            return socps;
        }

        /// <summary>
        /// 解析表达式
        /// </summary>
        /// <param name="exp"></param>
        public void AnalysisExpression(Expression exp)
        {
            switch (exp.NodeType)
            {
                case ExpressionType.Call:
                    {
                        var mce = exp as MethodCallExpression;
                        var methodName = mce.Method.Name;
                        IMethodHandler methodHandler;
                        if (!methodHandlerSet.ContainsKey(mce.Method.Name))
                        {
                            if (!methodHandlerTypeSet.ContainsKey(methodName))
                                throw new InvalidOperationException(methodName);
                            methodHandler = (IMethodHandler)Activator.CreateInstance(methodHandlerTypeSet[methodName], this);
                            methodHandlerSet[methodName] = methodHandler;
                        }
                        else
                            methodHandler = methodHandlerSet[methodName];
                        methodHandler.AnalysisExpression(exp);
                    }
                    break;
                case ExpressionType.Constant:
                    {
                        var ce = exp as ConstantExpression;
                        var entityType = ce.Value as IOrderedQueryable;
                        if (entityType == null || !entityClassesMap.ContainsKey(entityType.ElementType))
                            throw new InvalidOperationException();
                        Classes = entityClassesMap[entityType.ElementType];
                    }
                    break;
            }
        }

        /// <summary>
        /// 执行并返回结果
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public IEnumerable<T> Execute<T>()
        {
            IEnumerable dataSet = GetOriginalData<T>();
            foreach (var handler in ResultHandlers)
                dataSet = handler.Execute(dataSet);
            return dataSet.Cast<T>();
        }

        /// <summary>
        /// 获取原始数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private IEnumerable<T> GetOriginalData<T>()
        {
            var properties = typeof(T).GetProperties();

            var sql = new StringBuilder("SELECT ");
            sql.Append(string.Join(",", properties.Select(c => c.Name).ToArray()));
            sql.Append($" FROM {Classes.Name}");
            if (!string.IsNullOrEmpty(Where))
                sql.Append($" WHERE {Where}");

            using (var searcher = new ManagementObjectSearcher(GetScope(Classes.Scope), new ObjectQuery(sql.ToString())))
            {
                foreach (ManagementObject item in searcher.Get())
                {
                    var obj = Activator.CreateInstance<T>();
                    if (obj is EntityBase entityBase)
                        entityBase.BaseObject = item;
                    foreach (var property in properties)
                    {
                        property.SetValue(obj, GetValue(item.Properties[property.Name]), null);
                    }
                    yield return obj;
                }
            }
        }

        /// <summary>
        /// 获取WMI属性值
        /// </summary>
        /// <param name="propertyData"></param>
        /// <returns></returns>
        private object GetValue(PropertyData propertyData)
        {
            if (propertyData.Value == null)
                return null;
            if (propertyData.IsArray)
            {
                var orgArray = (propertyData.Value as Array);
                if (orgArray == null || orgArray.Length <= 0)
                    return null;
                var temp = new List<object>();
                foreach (var item in orgArray)
                    temp.Add(Converter(propertyData.Type, item));
                var resArr = Array.CreateInstance(temp.First().GetType(), orgArray.Length);
                for (int i = 0; i < resArr.Length; i++)
                    resArr.SetValue(temp[i], i);
                return resArr;
            }
            else
                return Converter(propertyData.Type, propertyData.Value);
        }

        /// <summary>
        /// 值由WMI类型转换为C#类型
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private object Converter(CimType type, object value)
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
    }
}
