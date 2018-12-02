using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;

namespace WmiFramework.Assistant.Components
{
    public static class ObjectExtension
    {
        /// <summary>
        /// 从限定符中获取描述信息
        /// </summary>
        /// <param name="qualifiers"></param>
        /// <returns></returns>
        public static string GetDescription(this QualifierDataCollection qualifiers)
        {
            foreach (var current in qualifiers)
            {
                if (current.Name.Equals("Description"))
                    return current.Value as string;
            }
            return string.Empty;
        }

        /// <summary>
        /// 获取属性值
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public static string GetValueString(this PropertyData property)
        {
            if (property.Value == null)
                return string.Empty;

            if (property.IsArray)
                return $"[{string.Join(",", (property.Value as Array).ToEnumerable<object>().Select(c => c == null ? string.Empty : string.Format("\"{0}\"", c.ToString())).ToArray())}]";
            else
                return property.Value.ToString();
        }

        /// <summary>
        /// IEnumerable转换为IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="org">原始</param>
        /// <returns></returns>
        public static IEnumerable<T> ToEnumerable<T>(this IEnumerable org)
        {
            foreach (var item in org)
                yield return (T)item;
        }
    }
}
