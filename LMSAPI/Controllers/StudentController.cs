using LMS.Model.Students;
using LMS.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LMSAPI.Controllers
{
    public class StudentController : ApiController
    {
        public IHttpActionResult Post(Student student)
        {
            StudentService studentService = new StudentService();

            var add = studentService.Add(student);
            return Ok(add);

        }
    }
}
