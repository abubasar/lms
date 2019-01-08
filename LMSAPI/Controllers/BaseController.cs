using LMS.Model;
using LMS.RequestModel;
using LMS.Service;
using LMS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace LMSAPI.Controllers
{
    public class BaseController<T,TR,TV> : ApiController where T:BaseEntity where TR:BaseRequestModel<T> where TV:BaseViewModel<T>
    {
        [Route("Add")]
        [ActionName("Add")]
        [HttpPost]
        public IHttpActionResult Add(T model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Bhai cob field sob field fill up koren");
            }
            model.Id = Guid.NewGuid().ToString();
            var service = new BaseService<T, TR, TV>();

            var add = service.Add(model);
            return Ok(add);

        }
    }
}