using LMS.Model.Courses;
using LMS.RequestModel;
using LMS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LMSAPI.Controllers
{
    [RoutePrefix("api/TeacherQuery")]
    public class CourseQueryController : BaseQueryController<Course,CourseRequestModel,CourseViewModel>
    {
     
       
    }
}