using MAssenger.DAL;
using MAssenger.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MAssenger.Controllers
{
    public class MessageController : ApiController
    {
        [HttpPost]
        public IHttpActionResult SendMessage([FromBody] JObject request)
        {
            Repo<Conversation> conversationRepo = new ConversationRepo();
            Repo<User> userRepo = new UserRepo();
            IPushNotifier notifier = new PNotifier();

            Message message = request.ToObject<Message>();
            Account to = new Account();
            to.Id = message.To.Id;

            Account from = new Account();
            from.Id = message.From.Id;
            message.Status = MessageStatus.Sent;
            Conversation find = new Conversation();

            find.Members.Add(from);
            find.Members.Add(to);
            find.conversationType = ConversationType.DoubleChat;
            find.Messages.Add(message);


            conversationRepo.Create(find);


            //conversation.NewMessage(message);
            //conversationRepo.Update(conversation);

            //List<User> members = find.Members;
            List<Account> account = new List<Account>();
            foreach(Account mem in find.Members)
            {
                account.Add(mem);
            }

            for (int i =0; i < account.Count; i++)
            {
                if (account[i].Id != from.Id)
                {
                    account[i] = userRepo.Read(account[i]);
                }
            }

            return Ok();
        }

        [HttpGet]
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
