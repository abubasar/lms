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
        public string Name { get; set; }

        public override Expression<Func<Teacher,bool>> GetExpression()
        {
            
            if (!string.IsNullOrWhiteSpace(Keyword))
            {
                this.ExpressionObject = x => x.Name.Contains(Keyword);

            }

            if (!string.IsNullOrWhiteSpace(Name))
            {
                this.ExpressionObject = x => x.Name.Contains(Name);

            }

            return this.ExpressionObject;
        }
       
    }
}
