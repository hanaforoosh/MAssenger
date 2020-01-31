using MAssenger.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace MAssenger.Models
{
    public class Account : AModel, IEquatable<Account>
    {
        public ICollection<Message> Inbox { get; set; }

        public Credential Credential { get; set; }

        public SeenStatus LastSeenStatus { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Bio { get; set; }

        public Image Avatar { get; set; }

        //public bool AddSessions(Session s)
        //{
        //    sessions.Add(s);
        //    return true;
        //}

        //public ICollection<Session> GetSession()
        //{
        //    return sessions;
        //}

        public Account()
        {
            Credential = new Credential();
        }
        public Account(UInt64 id, string username, string password)
        {
            //Id = id;
            //Password = password;
            //Username = username;
        }

        public bool Receive(Message message)
        {
            //return this.Id == message.Id &&
            //       this.Username == message.Username &&
            //       this.Inbox == message.Inbox &&
            //       this.PhoneNumber == message.PhoneNumber;
            throw new NotImplementedException();
        }

        public bool Equals(Account other)
        {
            throw new NotImplementedException();
        }

        public void notify()
        {
            throw new NotImplementedException();
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
    }
}