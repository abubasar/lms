using LMS.Model.Students;
using LMS.Repository;
using LMS.RequestModel;
using LMS.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Service
{
    public class StudentService:BaseService<Student>
    {
        private BaseRepository<Student> studentRepository;

        public StudentService()
        {
            this.studentRepository = new BaseRepository<Student>();
        }

        public bool Add(Student student)
        {
          
           return studentRepository.Add(student);
        }

        public List<StudentGridViewModel> Search(StudentRequestModel request )
        {

            //IQueryable<Student> students = this.studentRepository.Get();


            //Expression<Func<Student, bool>> nameExpression = x => x.Name.ToLower().Contains(request.Name.ToLower());//c12v3
            //Expression<Func<Student, bool>> phoneExpression = x => x.Phone.ToLower().Contains(request.Phone.ToLower());//c12v3
            //we need a queryable variable


            /*.....................Searching start.............................*/
            //we add where clauses
            // if (!string.IsNullOrWhiteSpace(request.Name))
            //     //students = students.Where(x => x.Name.ToLower().Contains(request.Name.ToLower()));
            //  students = students.Where(nameExpression);//c12v3
            // }

            // if (!string.IsNullOrWhiteSpace(request.Phone))
            // {
            // students = students.Where(x => x.Phone.ToLower().Contains(request.Phone.ToLower()));

            //students = students.Where(phoneExpression);//c12v3
            //}
            //students = students.Where(x => x.Name.ToLower().Contains(request.Name.ToLower()) && x.Phone.ToLower().Contains(request.Phone.ToLower()));


            /*
             Expression<Func<Student, bool>> expression = request.GetExpression();
             students = students.Where(expression);
            */


            /*.....................Searching end.............................*/


            /*.....................Sorting start.............................*/


            /*   students = students.OrderBy(x => x.Modified);
               if (!string.IsNullOrWhiteSpace(request.OrderBy))
               {
                   if (request.OrderBy.ToLower() == "name")
                   {
                       students = request.IsAscending ? students.OrderBy(x => x.Name) : students.OrderByDescending(x => x.Name);
                   }

                   if (request.OrderBy.ToLower() == "phone")
                   {
                       students = request.IsAscending ? students.OrderBy(x => x.Phone) : students.OrderByDescending(x => x.Phone);
                   }
               } */




            // students = request.OrderByFunc()(students);




            /*.....................Sorting end............................*/


            // students = students.Skip(0).Take(10);

            //students = students.Skip((request.Page - 1) * 10).Take(request.PerPageCount);    //paging
            //students = request.SkipAndTake(students);                                                                               //then we do the tolist(to fetch the resultant data to the memory)

            var students = base.SearchQueryable(request);

            var list = students.ToList().ConvertAll(x => new StudentGridViewModel(x));    //hit to database  and execute the query
          
            return list;
        }

        public StudentDetailViewModel Detail(string id)
        {
            Student x = this.studentRepository.GetDetail(id);
            if (x == null)
                //id vul disos can
            {
                throw new ObjectNotFoundException();
            }

            StudentDetailViewModel vm = new StudentDetailViewModel(x);

            return vm;
        }
    }
}
