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
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime Modified { get; set; }


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

           
            

            if (!string.IsNullOrWhiteSpace(this.Keyword))
            {
                this.ExpressionObject = x => x.Name.Contains(Keyword) || x.Phone.Contains(Keyword) || x.Email.Contains(Keyword);
            }

            if (!string.IsNullOrWhiteSpace(Name))
            {
               this.ExpressionObject=x => x.Name.Contains(Name);
            }

            if (!string.IsNullOrWhiteSpace(Phone))
            {
                this.ExpressionObject =x => x.Phone.Contains(Phone);
            }

         //this.ExpressionObject =this.GenerateBaseExpression();

            return this.ExpressionObject;
        }
       
       
        //public string Name { get; set; }
       // public string Phone { get; set; }

        //public string Email { get; set; }

       // public string Keyword { get; set; }

       
    }
}
