using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MAssenger.DAL;
using MAssenger.Models;

namespace MAssenger.Controllers
{
    public class AccountController : ApiController
    {
        //private readonly ProfileRepo profileRepo = new ProfileRepo();
        //[HttpGet]
        //public IHttpActionResult Get(UInt64 id)
        //{
        //    Profile profile = profileRepo.Read(new Profile(id));
        //    return Ok(profile);
        //}

        //[HttpGet]
        //public IHttpActionResult GetAll()
        //{
        //    return Ok(profileRepo.ReadAll());
        //}

        //[HttpPost]
        //public IHttpActionResult Add([FromUri] Profile profile)
        //{
        //    Profile result = profileRepo.Create(profile);
        //    return Ok(result);
        //}

        //[HttpPut]
        //public IHttpActionResult Update([FromUri] Profile profile)
        //{
        //    Profile result = profileRepo.Update(profile);
        //    return Ok(result);
        //}


        //[HttpDelete]
        //public IHttpActionResult Delete([FromUri] Profile profile)
        //{
        //    bool result = profileRepo.Delete(profile);
        //    return Ok(result);
        //}





    }
}