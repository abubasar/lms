using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.RequestModel
{
    using System.Data.Entity;
    using System.Linq.Expressions;
    using LMS.Model;

    public class StudentContentRequestModel : BaseRequestModel<StudentContent>
    {
        public override Expression<Func<StudentContent, bool>> GetExpression()
        {
            if (!string.IsNullOrWhiteSpace(Keyword))
            {
                this.ExpressionObject = x =>
                    x.Student.Name.Contains(Keyword) || x.Content.Title.Contains(Keyword);
            }


            return this.ExpressionObject;
        }

        public override IQueryable<StudentContent> IncludeParents(IQueryable<StudentContent> queryable)
        {
            return queryable.Include(e => e.Student).Include(e => e.Content);
        }
    }

    }
