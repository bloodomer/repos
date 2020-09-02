using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIRoutingExample.Filters;
using WebAPIRoutingExample.Models;

namespace WebAPIRoutingExample.Controllers
{
    [MyModelValidation]
    public class UserController : ApiController
    {
        // POST: api/User
        [HttpPost]
        public HttpResponseMessage Post([FromBody] User value)
        {
            
                return Request.CreateResponse(HttpStatusCode.Created, "Kullanıcı Oluşturuldu");
        }


       
    }
}
