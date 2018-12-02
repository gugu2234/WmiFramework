using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace WmiFramework
{
    class OrderByResultHandler : IResultHandler
    {
        private PropertyInfo propertyInfo;
        private bool isDesc;

        public OrderByResultHandler(MemberInfo member, bool isDesc)
        {
            this.isDesc = isDesc;
            propertyInfo = member as PropertyInfo;
            if (propertyInfo == null)
                throw new InvalidOperationException();
        }

        public IEnumerable Execute(IEnumerable dataSet)
        {
            if (isDesc)
                return dataSet.Cast<object>().OrderByDescending(c => propertyInfo.GetValue(c, null));
            else
                return dataSet.Cast<object>().OrderBy(c => propertyInfo.GetValue(c, null));
        }
    }
}
