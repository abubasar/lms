using LMS.Model.Teachers;
using LMS.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LMSAPI.Controllers
{
    public class TeacherController : ApiController
    {
        public IHttpActionResult Post(Teacher teacher)
        {
            TeacherService studentService = new TeacherService();

            var isAdd = studentService.Add(teacher);
            return Ok(isAdd);

        }
    }
}