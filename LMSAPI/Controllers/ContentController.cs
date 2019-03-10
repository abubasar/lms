using LMS.Model;
using LMS.RequestModel;
using LMS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace LMSAPI.Controllers
{
    [RoutePrefix("api/Content")]
    public class ContentController:BaseController<Content,ContentRequestModel,ContentViewModel>
    {
    }
}