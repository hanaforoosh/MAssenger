using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MAssenger.Controllers
{
    public class ConversationController : ApiController
    {
        [HttpGet]
        public IHttpActionResult JoinConversation([FromBody] JObject request)
        {
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult CreateConversation([FromBody] JObject request)
        {
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult LeaveConversation([FromBody] JObject request)
        {
            return Ok();
        }

    }
}
