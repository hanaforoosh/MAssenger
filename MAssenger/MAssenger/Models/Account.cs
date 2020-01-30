using System;
using System.Collections.Generic;

namespace MAssenger.Models
{
    public class Account : AModel, IEquatable<Account>
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Profile Profile
        {
            get => default;
            set
            {
            }
        }

        public ICollection<Message> Inbox { get; set; }

        public Credential Credential
        {
            get => default;
            set
            {
            }
        }

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

        }
        public Account(UInt64 id, string username, string password)
        {
            Id = id;
            Password = password;
            Username = username;
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

        public Profile Profile1
        {
            get => default;
            set
            {
            }
        }
    }
}