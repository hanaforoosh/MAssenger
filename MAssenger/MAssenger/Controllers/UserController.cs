
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
        private readonly Repo<User>  userRepo = new UserRepo();

        [HttpGet]
        public IHttpActionResult Get(UInt64 id)
        {
            User user = userRepo.Read(id);
            return Ok(user);
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(userRepo.ReadAll());
        }

        [HttpPost]
        public IHttpActionResult Add([FromUri] User user)
        {
            bool result = userRepo.Create(user);
            return Ok(result);
        }

        [HttpPut]
        public IHttpActionResult Update([FromUri] User user)
        {
            bool result = userRepo.Update(user);
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
