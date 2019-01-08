using LMS.Model.Teachers;
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
    public class TeacherService:BaseService<Teacher,TeacherRequestModel,TeacherDetailViewModel>
    {
       // private BaseRepository<Teacher> teacherRepository;

        public TeacherService()
        {
            //this.teacherRepository = new BaseRepository<Teacher>();
        }

      

        //public List<TeacherGridViewModel> Search(TeacherRequestModel request)
        //{
            //Expression<Func<Teacher,bool>> expression=request.GetExpression();

            //we need a queryable variable
            //IQueryable<Teacher> teachers = this.teacherRepository.Get();


            /*.....................Searching start.............................*/
            //we add where clauses

            /* if (!string.IsNullOrWhiteSpace(request.Name))
             {
                 teachers = teachers.Where(x => x.Name.ToLower().Contains(request.Name.ToLower()));
             }*/

            //teachers = teachers.Where(expression);
            //select * from teachers where expression

            /*.....................Searching end.............................*/


            /*.....................Sorting start.............................*/



            /*
            teachers = teachers.OrderBy(x => x.Modified);
            if (!string.IsNullOrWhiteSpace(request.OrderBy))
            {
                if (request.OrderBy.ToLower() == "name")
                {
                    teachers = request.IsAscending ? teachers.OrderBy(x => x.Name) : teachers.OrderByDescending(x => x.Name);
                }

            }*/

            //Func<IQueryable<Teacher>,IOrderedQueryable<Teacher>> orderByFunc = request.OrderByFunc();
            //teachers = orderByFunc(teachers);
            /*...............===..............*/
            //teachers = request.OrderByFunc()(teachers);


            /*.....................Sorting end............................*/


            // students = students.Skip(0).Take(10);

            //teachers = teachers.Skip((request.Page - 1) * 10).Take(request.PerPageCount);    //paging

            //teachers = request.SkipAndTake(teachers);                                                                           //then we do the tolist(to fetch the resultant data to the memory)

            //var teachers = base.SearchQueryable(request);
            //var list =teachers.ToList().ConvertAll(x => new TeacherGridViewModel(x));    //hit to database  and execute the query

            //return list;
       // }

       /* public TeacherDetailViewModel Detail(string id)
        {
            Teacher x = this.teacherRepository.GetDetail(id);
            if (x == null)
            //id vul disos can
            {
                throw new ObjectNotFoundException();
            }

            TeacherDetailViewModel vm = new TeacherDetailViewModel(x);

            return vm;*/
        }
    }



