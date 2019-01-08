using LMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LMS.RequestModel
{
    public abstract class BaseRequestModel<T> where T:BaseEntity
    {
        protected Expression<Func<T, bool>> ExpressionObject = e => true;// protected:-ai property ta baserequestmodel er bassa jara tara pabe
        public BaseRequestModel()
        {
            PerPageCount = 10;
            Page = 1;
            this.ExpressionObject = x => true;//initializing the expressionObject true

        }

        public int Page { get; set; }

        public int PerPageCount { get; set; }

        public string OrderBy { get; set; }

        public bool IsAscending { get; set; }

        public string Keyword { get; set; }

        public Func<IQueryable<T>,IOrderedQueryable<T>> OrderByFunc()//order by lambda expression generate kore dibe
        {
            string propertyName = OrderBy;
            bool ascending = IsAscending;
            var source = Expression.Parameter(typeof(IQueryable<T>), "source");
            var item = Expression.Parameter(typeof(T), "item");
            var member = Expression.Property(item, propertyName);
            var selector = Expression.Quote(Expression.Lambda(member, item));
            var body = Expression.Call(
                typeof(Queryable),ascending ?"OrderBy":"OrderByDescending",
                new[] {item.Type,member.Type},
                source,selector);
            var expr = Expression.Lambda<Func<IQueryable<T>, IOrderedQueryable<T>>>(body, source);
            var func = expr.Compile();
            return func;

              

        }

        public IQueryable<T> SkipAndTake(IQueryable<T> queryable){
            if (Page != -1)
            {
                queryable = queryable.Skip((Page - 1) * PerPageCount).Take(PerPageCount);
            }
            return queryable;
        
        }

       


        public abstract Expression<Func<T, bool>> GetExpression();


        /*
        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        protected Expression<Func<T,bool>> GenerateBaseExpression()
        {
            Expression<Func<T, bool>> expression = e => true;
            if(Start!=new DateTime())
            {
                if(End==new DateTime())
                {
                    End = Start.Date.AddDays(1).AddMinutes(-1);
                }
                expression= expression.ReduceAndCheck(x => x.Modified >= Start && x.Modified <= End);
            }

            return expression;
        }
*/

    }
}
