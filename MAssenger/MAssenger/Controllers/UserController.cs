
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MAssenger.Controllers
{
    public class UserController : ApiController
    {
        private List<User> users

        [HttpGet]
        public IHttpActionResult Get([FromUri] Request req)
        {  
            return Ok(req.GetContent<Test>());
        }

    }

    public class Test
    {
        private int x;
        public string Mystring { get; set; }
    }
}
