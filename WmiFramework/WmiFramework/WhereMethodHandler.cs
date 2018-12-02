using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace WmiFramework
{
    [MethodHandler("Where")]
    class WhereMethodHandler : IMethodHandler
    {
        private Context context;

        public WhereMethodHandler(Context context)
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
                        var le = ue.Operand as LambdaExpression;
                        if (le == null || !(le.Body is BinaryExpression))
                            context.AnalysisExpression(ue);
                        else
                            GeneratedSql((BinaryExpression)le.Body);
                        break;
                    default:
                        context.AnalysisExpression(mce.Arguments[i]);
                        break;
                }
            }
        }

        private void GeneratedSql(BinaryExpression exp)
        {
            var sql = BinarExpressionProvider(exp.Left, exp.Right, exp.NodeType);
            context.Where = string.IsNullOrEmpty(context.Where) ? $"({sql})" : $" AND ({sql})";
        }

        /// <summary>
        /// 拆分、拼接sql
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        private string BinarExpressionProvider(Expression left, Expression right, ExpressionType type)
        {
            string sb = "(";
            sb += ExpressionRouter(left);
            sb += ExpressionTypeCast(type);
            string tmpStr = ExpressionRouter(right);
            if (tmpStr == "null")
            {
                if (sb.EndsWith(" =")) sb = sb.Substring(0, sb.Length - 2) + " is null";
                else if (sb.EndsWith("<>")) sb = sb.Substring(0, sb.Length - 2) + " is not null";
            }
            else sb += tmpStr;
            return sb += ")";
        }

        /// <summary>
        /// 拆分、拼接sql
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        private string ExpressionRouter(Expression exp)
        {
            string sb = string.Empty;
            if (exp is BinaryExpression)
            {
                var be = exp as BinaryExpression;
                return BinarExpressionProvider(be.Left, be.Right, be.NodeType);
            }
            else if (exp is MemberExpression)
            {
                var me = exp as MemberExpression;
                return me.Member.Name;
            }
            else if (exp is NewArrayExpression)
            {
                var ae = exp as NewArrayExpression;
                StringBuilder tmpstr = new StringBuilder();
                foreach (Expression ex in ae.Expressions)
                {
                    tmpstr.Append(ExpressionRouter(ex));
                    tmpstr.Append(",");
                }
                return tmpstr.ToString(0, tmpstr.Length - 1);
            }
            else if (exp is MethodCallExpression)
            {
                throw new InvalidOperationException();
                //var mce = exp as MethodCallExpression;
                //var attributeData = mce.Method.GetCustomAttributes(typeof(ToSqlFormat), false).First();
                //return string.Format(((ToSqlFormat)attributeData).Format, ExpressionRouter(mce.Arguments[0]), ExpressionRouter(mce.Arguments[1]));
            }
            else if (exp is ConstantExpression)
            {
                var ce = exp as ConstantExpression;
                if (ce.Value == null)
                    return "null";
                else if (ce.Value is ValueType)
                    return ce.Value.ToString();
                else if (ce.Value is string || ce.Value is DateTime || ce.Value is char)
                    return string.Format("'{0}'", ce.Value.ToString());
            }
            else if (exp is UnaryExpression)
            {
                UnaryExpression ue = ((UnaryExpression)exp);
                return ExpressionRouter(ue.Operand);
            }

            return null;
        }

        /// <summary>
        /// 介绍表达式树节点的节点类型 转换为 sql关键字
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private string ExpressionTypeCast(ExpressionType type)
        {
            switch (type)
            {
                case ExpressionType.And:
                    return " & ";
                case ExpressionType.AndAlso:
                    return " AND ";
                case ExpressionType.Equal:
                    return " =";
                case ExpressionType.GreaterThan:
                    return " >";
                case ExpressionType.GreaterThanOrEqual:
                    return ">=";
                case ExpressionType.LessThan:
                    return "<";
                case ExpressionType.LessThanOrEqual:
                    return "<=";
                case ExpressionType.NotEqual:
                    return "<>";
                case ExpressionType.Or:
                    return " | ";
                case ExpressionType.OrElse:
                    return " OR ";
                case ExpressionType.Add:
                case ExpressionType.AddChecked:
                    return "+";
                case ExpressionType.Subtract:
                case ExpressionType.SubtractChecked:
                    return "-";
                case ExpressionType.Divide:
                    return "/";
                case ExpressionType.Multiply:
                case ExpressionType.MultiplyChecked:
                    return "*";
                default:
                    return null;
            }
        }
    }
}
