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
    public class ConversationController : ApiController
    {
        [HttpGet]
        public IHttpActionResult JoinConversation([FromBody] JObject request)
        {
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult CreateConversation([FromBody] JObject request)
        {
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult LeaveConversation([FromBody] JObject request)
        {
            return Ok();
        }


        //public ICollection<Conversation> GetConversationByAmodel_id(AModel aModel)
        //{
            
        //    List<Conversation> SelectedConversations = new List<Conversation>();
        //    Repo <Conversation> conversationRepo = new ConversationRepo();
        //    ICollection<Conversation> AllConversations = conversationRepo.ReadAll();
        //    foreach(Conversation co in AllConversations)
        //    {
        //        foreach(Account ac in co.Members)
        //        {
        //            if(ac.Id == aModel.Id)
        //            {
        //                SelectedConversations.Add(co);
        //            }
        //        }
        //    }
        //    return SelectedConversations;
        //}
    }
}
