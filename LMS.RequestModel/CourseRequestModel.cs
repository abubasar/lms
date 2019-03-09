using LMS.Model.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LMS.RequestModel
{
    public class CourseRequestModel : BaseRequestModel<Course>
    {
        public override Expression<Func<Course, bool>> GetExpression()
        {
            if (!string.IsNullOrWhiteSpace(this.Keyword))
            {
                this.ExpressionObject = x => x.Title.Contains(Keyword) || x.Tags.Contains(Keyword)||x.Teacher.Name.Contains(Keyword);
            }
            return this.ExpressionObject;
        }

        public override IQueryable<Course> IncludeParents(IQueryable<Course> queryable)
        {
            return IncludeParents(queryable);
        }
    }
}
