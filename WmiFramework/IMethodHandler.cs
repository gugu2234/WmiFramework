using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace WmiFramework
{
    /// <summary>
    /// 方法处理器接口
    /// </summary>
    interface IMethodHandler
    {
        /// <summary>
        /// 解析表达式
        /// </summary>
        /// <param name="exp"></param>
        void AnalysisExpression(Expression exp);
    }
}
