using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WmiFramework
{
    /// <summary>
    /// 结果处理器
    /// </summary>
    interface IResultHandler
    {
        /// <summary>
        /// 执行
        /// </summary>
        /// <param name="dataSet">数据集</param>
        /// <returns>处理后数据集</returns>
        IEnumerable Execute(IEnumerable dataSet);
    }
}
