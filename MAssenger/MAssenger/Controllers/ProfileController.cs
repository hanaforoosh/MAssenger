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
    public class ProfileController : ApiController
    {
        [HttpPost]
        public IHttpActionResult GetBio([FromBody] JObject request)
        {
            Account user = request.ToObject<Account>();
            Repo<Account> cr = new AccountRepo();
            user = cr.Read(user);
            return Ok(user.Bio);
        }
        [HttpPost]
        public IHttpActionResult SetBio([FromBody] JObject request)
        {
            Account user = request.ToObject<Account>();
            Repo<Account> cr = new AccountRepo();
            cr.Update(user);
            return Ok();
        }
        [HttpPost]
        public IHttpActionResult GetAvatar([FromBody] JObject request)
        {
            Account user = request.ToObject<Account>();
            Repo<Account> cr = new AccountRepo();
            user = cr.Read(user);
            return Ok(user.Avatar);
        }
        [HttpPost]
        public IHttpActionResult SetAvatar([FromBody] JObject request)
        {
            return Ok();
        }
        [HttpPost]
        public IHttpActionResult SetPhonenumber([FromBody] JObject request)
        {
            User user = request.ToObject<User>();
            Repo<User> cr = new UserRepo();
            user = cr.Update(user);
            return Ok();
        }
        [HttpPost]
        public IHttpActionResult GetPhonenumber([FromBody] JObject request)
        {
            User user = request.ToObject<User>();
            Repo<User> cr = new UserRepo();
            user = cr.Read(user);
            return Ok(user.PhoneNumber);
        }
    }
}
