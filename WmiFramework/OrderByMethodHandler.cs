using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace WmiFramework
{
    [MethodHandler("OrderBy")]
    class OrderByMethodHandler : IMethodHandler
    {
        private Context context;

        public OrderByMethodHandler(Context context)
        {
            this.context = context;
        }

        public void AnalysisExpression(Expression exp)
        {
            var mce = exp as MethodCallExpression;
            for (int i = 0; i < mce.Arguments.Count; i++)
            {
                switch (mce.Arguments[i].NodeType)
                {
                    case ExpressionType.Quote:
                        var ue = mce.Arguments[i] as UnaryExpression;
                        if (ue.Operand.NodeType != ExpressionType.Lambda)
                            context.AnalysisExpression(mce.Arguments[i]);
                        else
                        {
                            var le = (LambdaExpression)ue.Operand;
                            if (le.Body.NodeType != ExpressionType.MemberAccess)
                                throw new InvalidOperationException("不支持的语法");
                            context.ResultHandlers.Add(new OrderByResultHandler(((MemberExpression)le.Body).Member, false));
                        }
                        break;
                    default:
                        context.AnalysisExpression(mce.Arguments[i]);
                        break;
                }
            }
        }
    }
}
