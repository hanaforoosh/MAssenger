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
    public class GroupController : ApiController
    {
        [HttpGet]
        public IHttpActionResult SelectAdmin([FromBody] JObject request)
        {
            User conv = request["user"].ToObject<User>();
            Repo<Group> cr = new GroupRepo();
            Group group = request["group"].ToObject<Group>();
            group.Admin = conv;
            cr.Update(group);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult ChangeAdmin([FromBody] JObject request)
        {
            User conv = request["user"].ToObject<User>();
            Repo<Group> cr = new GroupRepo();
            Group group = request["group"].ToObject<Group>();
            group.Admin = conv;
            cr.Update(group);
            return Ok();
        }
        [HttpGet]
        public IHttpActionResult UnsetAdmin([FromBody] JObject request)
        {
            Repo<Group> cr = new GroupRepo();
            Group group = request.ToObject<Group>();
            group.Admin = null;
            cr.Update(group);
            return Ok();
        }
        [HttpGet]
        public IHttpActionResult PinMessage([FromBody] JObject request)
        {
            Message msg = request["message"].ToObject<Message>();
            Repo<Group> cr = new GroupRepo();
            Group group = request["group"].ToObject<Group>();
            group.PinnedMessage = msg;
            cr.Update(group);
            return Ok();
        }
        [HttpGet]
        public IHttpActionResult UnPinMessage([FromBody] JObject request)
        {
            Message msg = request["message"].ToObject<Message>();
            Repo<Group> cr = new GroupRepo();
            Group group = request["group"].ToObject<Group>();
            group.PinnedMessage = null;
            cr.Update(group);
            return Ok();
        }

    }
}
