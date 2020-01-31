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
    public class DoubleChatController : ApiController
    {
        [HttpGet]
        public IHttpActionResult MarkMessageInChat([FromBody] JObject request)
        {
            Message msg = request["message"].ToObject<Message>();
            Repo<DoubleChat> cr = new DoubleChatRepo();
            DoubleChat chat = request["chat"].ToObject<DoubleChat>();
            chat.MarkMessage(msg);
            cr.Update(chat);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult UnMarkMessageInChat([FromBody] JObject request)
        {
            Message msg = request["message"].ToObject<Message>();
            Repo<DoubleChat> cr = new DoubleChatRepo();
            DoubleChat chat = request["chat"].ToObject<DoubleChat>();
            chat.UnMarkMessage(msg);
            cr.Update(chat);
            return Ok();
        }
    }
}
