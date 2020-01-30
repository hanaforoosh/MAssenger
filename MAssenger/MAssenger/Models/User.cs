using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAssenger.Models
{
    public class User : Account, IEquatable<User>
    {
        private ICollection<Conversation> Conversations = new List<Conversation>();

        public string PhoneNumber { get; set; }
        public User()
        {

        }
        public User(UInt64 id, string username, string password, string phonenumber)
        {
            Id = id;
            Password = password;
            Username = username;
            PhoneNumber = phonenumber;
        }

        public bool AddConversation(Conversation c)
        {
            Conversations.Add(c);
            return true;
        }

        public bool AddMessageToInbox(Message c)
        {
            Inbox.Add(c);
            return true;
        }
        public bool RemoveMessageFromInbox(Message c)
        {
            Inbox.Remove(c);
            return true;
        }


        public bool Equals(User other)
        {
            throw new NotImplementedException();
        }
    }
}