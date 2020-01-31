using MAssenger.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace MAssenger.Models
{
    public class Account : AModel, IEquatable<Account>
    {
        private AccountRepo accountRepo = new AccountRepo();
        public ICollection<Message> Inbox { get; set; }

        public Credential Credential { get; set; }

        public SeenStatus LastSeenStatus { get; set; }

        public DateTime LastSeen { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Bio { get; set; }

        public Image Avatar { get; set; }

        public Account Create(Account entity)
        {
            return accountRepo.Create(entity);
        }

        public Account Read(AModel amodel)
        {
            return accountRepo.Read(amodel);
        }

        public ICollection<Account> ReadAll()
        {
            return accountRepo.ReadAll();
        }

        public Account Update(Account entity)
        {
            return accountRepo.Update(entity);
        }

        public bool Delete(Account entity)
        {
            return accountRepo.Delete(entity);
        }

        public bool Delete(AModel aModel)
        {
            return accountRepo.Delete(aModel);
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

    }
}