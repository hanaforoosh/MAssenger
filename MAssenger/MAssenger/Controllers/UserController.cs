
using MAssenger.DAL;
using MAssenger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MAssenger.Controllers
{
    public class UserController : ApiController
    {
        private Repo<User> userRepo = new UserRepo();
        private IAuthentication mauth = new MAAuth();
        [HttpGet]
        public IHttpActionResult Get([FromUri] AModel model)
        {
            User user = userRepo.Read(model);
            return Ok(user);
        }

        [HttpPost]
        public IHttpActionResult Login([FromUri] Credential cr)
        {

            Session session = mauth.Login(cr);
            if (session == null)
                return Unauthorized();
            return Ok(session);
        }
        [HttpPost]
        public IHttpActionResult Signup([FromUri] Credential cr)
        {
            Session session = mauth.SignUp(cr);
            if (session == null)
                return Unauthorized();
            return Ok(session);
        }
        [HttpPost]
        public IHttpActionResult Signupur([FromUri] User ur)
        {
            Session session = mauth.SignUp(ur);
            if (session == null)
                return Unauthorized();
            return Ok(session);
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(userRepo.ReadAll());
        }

        [HttpPost]
        public IHttpActionResult Add([FromUri] User user)
        {
            
            User result = userRepo.Create(user);
            return Ok(result);
        }

        [HttpPut]
        public IHttpActionResult Update([FromUri] User user)
        {
            User result = userRepo.Update(user);
            return Ok(result);
        }

        [HttpDelete]
        public IHttpActionResult Delete([FromUri] User user)
        {
            bool result = userRepo.Delete(user);
            return Ok(result);
        }

    }

}
