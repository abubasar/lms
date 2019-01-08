using LMS.Model.Teachers;
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
    [RoutePrefix("api/Teacher")]
    public class TeacherController :BaseController<Teacher,TeacherRequestModel,TeacherDetailViewModel>
    {
        
    }
}