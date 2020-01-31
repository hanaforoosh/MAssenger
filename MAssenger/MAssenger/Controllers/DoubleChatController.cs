using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MAssenger.Controllers
{
    public class DoubleChatController : ApiController
    {
        [HttpGet]
        public IHttpActionResult MarkMessageInChat([FromBody] JObject request)
        {
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult UnMarkMessageInChat([FromBody] JObject request)
        {
            return Ok();
        }
    }
}
