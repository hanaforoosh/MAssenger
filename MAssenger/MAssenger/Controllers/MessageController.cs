using MAssenger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MAssenger.Controllers
{
    public class MessageController : ApiController
    {
        public IHttpActionResult SendMessage(Message message, Session session)
        {
            throw new System.NotImplementedException();
        }

        [HttpPut]
        public IHttpActionResult EditMessage(Message message, Session session)
        {
            throw new System.NotImplementedException();
        }

        [HttpDelete]
        public IHttpActionResult DeleteMessage(Message message, Session session)
        {
            throw new System.NotImplementedException();
        }
    }
}
