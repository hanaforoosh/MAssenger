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
    public class MessageController : ApiController
    {
        public IHttpActionResult SendMessage([FromBody] JObject request)
        {
            //Repo<Conversation> conversationRepo = new ConversationRepo();
            //Repo<User> userRepo = new UserRepo();
            //IPushNotifier notifier = new PNotifier();

            //Message message = request.ToObject<Message>();
            //var to = message.To;
            //var from = message.From;
            //message.Status = MessageStatus.Sent;

            //Conversation conversation =conversationRepo.Read(to);
            //conversation.NewMessage(message);
            //conversationRepo.Update(conversation);
            //var members = conversation.Members;
            //foreach (var mem in members)
            //{
            //    if (mem.Id != from.Id)
            //    {
            //        User user = userRepo.Read(mem);
            //        user.AddMessageToInbox(message);
            //        userRepo.Update(user);
            //        notifier.notify(message);
            //    }
            //}

            return Ok();
        }

        public IHttpActionResult GetNewMessages([FromBody] JObject request)
        {
            AModel model = request.ToObject<AModel>();
            Repo<User> userRepo = new UserRepo();
            User user = userRepo.Read(model);
            var inbox = user.Inbox;
            return Ok(inbox);
        }
        public IHttpActionResult GetAllMessages([FromBody] JObject request)
        {
            AModel model = request.ToObject<AModel>();
            Repo<User> userRepo = new UserRepo();
            User user = userRepo.Read(model);
            var conversations = user.GetConversations();
            return Ok(conversations);
        }


        [HttpPut]
        public IHttpActionResult EditMessage([FromBody] JObject request)
        {
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteMessage([FromBody] JObject request)
        {
            return Ok();
        }
    }
}
