using LMS.Model.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LMS.RequestModel
{
   public class TeacherRequestModel:BaseRequestModel<Teacher>
    {
        public Expression<Func<Teacher, bool>> expression;

        public override Expression<Func<Teacher,bool>> GetExpression()
        {
            this.expression = x => true;
            if (!string.IsNullOrWhiteSpace(Keyword))
            {
                this.expression = x => x.Name.Contains(Keyword);

            }
            return this.expression;
        }
        //public string Keyword { get; set; }
    }
}
