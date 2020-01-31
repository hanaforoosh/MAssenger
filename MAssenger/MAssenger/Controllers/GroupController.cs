using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MAssenger.Controllers
{
    public class GroupController : ApiController
    {
        [HttpGet]
        public IHttpActionResult SelectAdmin([FromBody] JObject request)
        {
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult ChangeAdmin([FromBody] JObject request)
        {
            return Ok();
        }
        [HttpGet]
        public IHttpActionResult UnsetAdmin([FromBody] JObject request)
        {
            return Ok();
        }
        [HttpGet]
        public IHttpActionResult PinMessage([FromBody] JObject request)
        {
            return Ok();
        }
        [HttpGet]
        public IHttpActionResult UnPinMessage([FromBody] JObject request)
        {
            return Ok();
        }

    }
}
