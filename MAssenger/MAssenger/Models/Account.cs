using System;
using System.Collections.Generic;
using System.Drawing;

namespace MAssenger.Models
{
    public class Account : AModel, IEquatable<Account>
    {

        public ICollection<Message> Inbox { get; set; }

        public Credential Credential
        {
            get => default;
            set
            {
            }
        }

        public SeenStatus LastSeenStatus { get; set; }

        public DateTime LastSeen
        {
            get => default;
            set
            {
            }
        }

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

    }
}