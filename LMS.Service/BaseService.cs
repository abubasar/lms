using LMS.Model;
using LMS.Model.Students;
using LMS.Repository;
using LMS.RequestModel;
using LMS.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Service
{
   public class BaseService<T,Tr,Tv> where T:BaseEntity where Tr:BaseRequestModel<T> where Tv:BaseViewModel<T>
    {
        BaseRepository<T> repository = new BaseRepository<T>();
        public IQueryable<T> SearchQueryable(BaseRequestModel<T> request)
        {
          

            /*  IQueryable<Student> students = this.studentRepository.Get();
              Expression<Func<Student, bool>> expression = request.GetExpression();
              students = students.Where(expression);
              students = request.OrderByFunc()(students);
              students = request.SkipAndTake(students);  */

            IQueryable<T> queryble = repository.Get();
            var expression = request.GetExpression();
            queryble = queryble.Where(expression);
            queryble = request.OrderByFunc()(queryble);
            queryble = request.SkipAndTake(queryble);
            queryble = request.IncludeParents(queryble);

            return queryble;
        }

        public bool Add(T model)
        {

            return repository.Add(model);
        }

        public Tv Detail(string id)
        {
            T x = repository.GetDetail(id);
            if (x == null)
            //id vul disos can
            {
                throw new ObjectNotFoundException();
            }

            var vm = CreateVmInstance(x);

            return vm;
        }

        public List<Tv> Search(Tr request)
        {

            var students = SearchQueryable(request);

            var list = students.ToList().ConvertAll(CreateVmInstance);    //hit to database  and execute the query

            return list;
        }

        private static Tv CreateVmInstance(T x)
        {
            return (Tv)Activator.CreateInstance(typeof(Tv), x);
        }

    }
}
