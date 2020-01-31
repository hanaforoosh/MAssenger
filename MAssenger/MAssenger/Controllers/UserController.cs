
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
        private User userModel = new User();

        [HttpGet]
        public IHttpActionResult Get(UInt64 id)
        {
            //set the parameters
            User user = userModel.Read(new User());
            return Ok(user);
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(userModel.ReadAll());
        }

        [HttpPost]
        public IHttpActionResult Add([FromUri] User user)
        {
            
            User result = userModel.Create(user);
            return Ok(result);
        }

        [HttpPut]
        public IHttpActionResult Update([FromUri] User user)
        {
            User result = userModel.Update(user);
            return Ok(result);
        }

        [HttpDelete]
        public IHttpActionResult Delete([FromUri] User user)
        {
            bool result = userModel.Delete(user);
            return Ok(result);
        }

    }

}
