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
    public class ChannelController : ApiController
    {
        [HttpGet]
        public IHttpActionResult AddAuthor([FromBody] JObject request)
        {
            Channel ch = request["channel"].ToObject<Channel>();
            Repo<Channel> cr = new ChannelRepo();
            Account author = request["author"].ToObject<Account>();
            ch.AddAuthor(author);
            cr.Update(ch);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult RemoveAuthor([FromBody] JObject request)
        {
            Channel ch = request["channel"].ToObject<Channel>();
            Repo<Channel> cr = new ChannelRepo();
            Account author = request["author"].ToObject<Account>();
            ch.RemoveAuthor(author);
            cr.Update(ch);
            return Ok();
        }
    }
}
