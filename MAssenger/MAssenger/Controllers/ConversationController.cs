using MAssenger.DAL;
using MAssenger.Models;
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
            Conversation conv = request["conversation"].ToObject<Conversation>();
            Repo<Conversation> cr = new ConversationRepo();
            Account user = request["account"].ToObject<Account>();
            conv.Join(user);
            cr.Update(conv);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult CreateConversation([FromBody] JObject request)
        {
            Conversation conv = request["conversation"].ToObject<Conversation>();
            Repo<Conversation> cr = new ConversationRepo();
            cr.Create(conv);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult LeaveConversation([FromBody] JObject request)
        {
            Conversation conv = request["conversation"].ToObject<Conversation>();
            Repo<Conversation> cr = new ConversationRepo();
            Account user = request["account"].ToObject<Account>();
            conv.Leave(user);
            cr.Update(conv);
            return Ok();
        }
    }
}
