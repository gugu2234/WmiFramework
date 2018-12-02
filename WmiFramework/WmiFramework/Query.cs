using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Management;
using System.Text;

namespace WmiFramework
{
    class Query<T> : IOrderedQueryable<T>
    {
        public Query(ConnectionOptions options, string address)
        {
            Provider = new QueryProvider(options, address);
            Expression = Expression.Constant(this);
        }

        public Query(QueryProvider provider)
        {
            Provider = provider;
            Expression = Expression.Constant(this);
        }

        public Query(QueryProvider provider, Expression expression)
        {
            Provider = provider;
            Expression = expression;
        }

        public Type ElementType
        {
            get { return typeof(T); }
        }

        public Expression Expression { get; private set; }

        public IQueryProvider Provider { get; private set; }

        public IEnumerator<T> GetEnumerator()
        {
            //return ((IEnumerable<T>)Provider.Execute(Expression)).GetEnumerator();
            var context = (Context)Provider.Execute(Expression);
            return context.Execute<T>().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
