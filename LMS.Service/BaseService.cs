using LMS.Model;
using LMS.Repository;
using LMS.RequestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Service
{
   public class BaseService<T> where T:BaseEntity
    {
        public IQueryable<T> SearchQueryable(BaseRequestModel<T> request)
        {
            var repository = new BaseRepository<T>();

            /*  IQueryable<Student> students = this.studentRepository.Get();
              Expression<Func<Student, bool>> expression = request.GetExpression();
              students = students.Where(expression);
              students = request.OrderByFunc()(students);
              students = request.SkipAndTake(students);  */

            IQueryable<T> students = repository.Get();
            var expression = request.GetExpression();
            students = students.Where(expression);
            students = request.OrderByFunc()(students);
            students = request.SkipAndTake(students);

            return students;
        }
         
    }
}
