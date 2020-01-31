using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MAssenger.DAL;
using MAssenger.Models;
using Newtonsoft.Json.Linq;

namespace MAssenger.Controllers
{
    public class AccountController : ApiController
    {
        readonly private Repo<User> userRepo = new UserRepo();
        readonly private IAuthentication mauth = new MAAuth();

        [HttpPost]
        public IHttpActionResult Login([FromBody] JObject request)
        {
            Credential cr = request.ToObject<Credential>();
            Session session = mauth.Login(cr);
            if (session == null)
                return NotFound();
            return Ok(session);
        }

        [HttpPost]
        public IHttpActionResult Signup([FromBody] JObject request)
        {
            Credential cr = request.ToObject<Credential>();
            Session session = mauth.SignUp(cr);
            if (session == null)
                return Unauthorized();
            return Ok(session);
        }

        [HttpDelete]
        public IHttpActionResult DeleteAccount([FromBody] JObject request)
        {
            Credential cr = request.ToObject<Credential>();
            bool result = userRepo.Delete(cr);
            return Ok(result);
        }


        //These codes is kept for test purposes
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(userRepo.ReadAll());
        }

        [HttpGet]
        public IHttpActionResult Get([FromBody] JObject request)
        {
            AModel model = request.ToObject<User>();
            User user = userRepo.Read(model);
            return Ok(user);
        }
    }
}