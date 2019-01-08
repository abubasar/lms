using LMS.Model;
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
    public class BaseQueryController<T, TR, TV> : ApiController where T : BaseEntity where TR : BaseRequestModel<T> where TV : BaseViewModel<T>
    {
        [Route("Search")]
        [ActionName("Search")]
        [HttpPost]
        public IHttpActionResult Search(TR request)

        {
            if (!ModelState.IsValid)
            {
                return BadRequest("bhai, Please sob field fill up koren");
            }
            var service = new BaseService<T, TR,TV>();
            var students = service.Search(request);
            return this.Ok(students);
        }
    }
}
