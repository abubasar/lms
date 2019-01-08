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
    [RoutePrefix("api/Student")]
    public class StudentController : BaseController<Student,StudentRequestModel,StudentViewModel>
    {
        /*
        public IHttpActionResult Post(Student student)
        {
            var service = new BaseService<Student, StudentRequestModel, StudentViewModel>();

            var add = service.Add(student);
            return Ok(add);

        }*/
    }
}
