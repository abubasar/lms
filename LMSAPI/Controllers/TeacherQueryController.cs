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
    public class TeacherQueryController : ApiController
    {

        public IHttpActionResult Post(TeacherRequestModel request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("bhai, Please sob field fill up koren");
            }
            TeacherService teacherService = new TeacherService();
            List<TeacherGridViewModel> teachers = teacherService.Search(request);
            return this.Ok(teachers);
        }
    }
}
