using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using LMS.Model;
using System.Data.Entity;
namespace LMS.RequestModel
{
   public class EnrollmentRequestModel:BaseRequestModel<Enrollment>
    {
        public override Expression<Func<Enrollment, bool>> GetExpression()
        {
            if (!string.IsNullOrWhiteSpace(Keyword))
            {
                this.ExpressionObject = x =>
                    x.Student.Name.Contains(Keyword) || x.Course.Title.Contains(Keyword);
            }

           
            return this.ExpressionObject;
        }

        public override IQueryable<Enrollment> IncludeParents(IQueryable<Enrollment> queryable)
        {
            return queryable.Include(e => e.Student).Include(e => e.Course);
        }

    }
}
