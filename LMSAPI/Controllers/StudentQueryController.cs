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
    public class StudentQueryController : ApiController
    {
        public IHttpActionResult Post(StudentRequestModel request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("bhai, Please sob field fill up koren");
            }
            StudentService studentService = new StudentService();
            List<StudentGridViewModel> students=studentService.Search(request);
            return this.Ok(students);
        }
    }
}
