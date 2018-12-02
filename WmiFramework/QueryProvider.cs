using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Management;

namespace WmiFramework
{
    class QueryProvider : IQueryProvider
    {
        private ConnectionOptions options;
        private string address;

        public QueryProvider(ConnectionOptions options, string address)
        {
            this.options = options;
            this.address = address;
        }

        public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
        {
            return new Query<TElement>(this, expression);
        }

        public IQueryable CreateQuery(Expression expression)
        {
            return (IQueryable)Activator.CreateInstance(typeof(Query<>).MakeGenericType(expression.Type), this, expression);
        }

        public TResult Execute<TResult>(Expression expression)
        {
            var obj = Activator.CreateInstance(typeof(TResult), options, address);
            ((Context)obj).AnalysisExpression(expression);
            return (TResult)obj;
        }

        public object Execute(Expression expression)
        {
            var context = new Context(options, address);
            context.AnalysisExpression(expression);
            return context;
        }
    }
}
