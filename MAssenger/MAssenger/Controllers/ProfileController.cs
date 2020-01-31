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
            return Ok();
        }
        public IHttpActionResult SetBio([FromBody] JObject request)
        {
            return Ok();
        }
        public IHttpActionResult GetAvatar([FromBody] JObject request)
        {
            return Ok();
        }
        public IHttpActionResult SetAvatar([FromBody] JObject request)
        {
            return Ok();
        }
        public IHttpActionResult SetPhonenumber([FromBody] JObject request)
        {
            return Ok();
        }
        public IHttpActionResult GetPhonenumber([FromBody] JObject request)
        {
            return Ok();
        }
    }
}
