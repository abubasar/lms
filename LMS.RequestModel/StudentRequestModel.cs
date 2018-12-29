using LMS.Model.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LMS.RequestModel
{
    public class StudentRequestModel:BaseRequestModel<Student>
    {
        Expression<Func<Student, bool>> expression;

        public override Expression<Func<Student,bool>> GetExpression()
        {
            /*
            if (!string.IsNullOrWhiteSpace(this.Name))
            {
                this.expression = x => x.Name.ToLower().Contains(this.Name.ToLower());
            }
            if (!string.IsNullOrWhiteSpace(this.Phone))
            {
                this.expression = x => x.Phone.ToLower().Contains(this.Phone.ToLower());
            }
            if (!string.IsNullOrWhiteSpace(this.Email))
            {
                this.expression = x => x.Email.ToLower().Contains(this.Email.ToLower());
            }
            */
            this.expression = x => true;

            if (!string.IsNullOrWhiteSpace(this.Keyword))
            {
                this.expression = x => x.Name.Contains(Keyword) || x.Phone.Contains(Keyword) || x.Email.Contains(Keyword);
            }

            return this.expression;
        }
       
       
        //public string Name { get; set; }
       // public string Phone { get; set; }

        //public string Email { get; set; }

       // public string Keyword { get; set; }
    }
}
