using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MAssenger.Controllers
{
    public class ChannelController : ApiController
    {
        [HttpGet]
        public IHttpActionResult AddAuthor([FromBody] JObject request)
        {
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult RemoveAuthor([FromBody] JObject request)
        {
            return Ok();
        }
    }
}
