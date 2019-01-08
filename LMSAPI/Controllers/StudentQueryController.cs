using LMS.Model.Students;
using LMS.RequestModel;
using LMS.Service;
using LMS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LMSAPI.Controllers
{
    [RoutePrefix("api/StudentQuery")]
    public class StudentQueryController : BaseQueryController<Student, StudentRequestModel,StudentGridViewModel>
    {
        /*
        public IHttpActionResult Post(StudentRequestModel request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("bhai, Please sob field fill up koren");
            }
            StudentService service = new StudentService();
            List<StudentGridViewModel> students = service.Search(request);
            return this.Ok(students);
        }
        */
        /*
        public IHttpActionResult Search(StudentRequestModel request)
            
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("bhai, Please sob field fill up koren");
            }
                        var service = new BaseService<Student,StudentRequestModel,StudentViewModel>();
                          var  students=service.Search(request);
                         return this.Ok(students);
        }*/
    }
}
