﻿using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections.Generic;
using MAssenger.Models;

namespace MAssenger
{
    public class Conversation : AModel, IEquatable<Conversation>
    {
        public System.Collections.Generic.ICollection<Account> Members = new List<Account>();
        public ICollection<Message> Messages = new List<Message>();

        public ConversationType conversationType;

        public bool Join(Account user)
        {
            Members.Add(user);
            return true;
        }
        public bool Leave(Account user)
        {
            try
            {
                Members.Remove(user);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public virtual bool NewMessage(Message m)
        {
            Messages.Add(m);
            return true;
        }
        public bool DeleteMessage(Message m)
        {
            try
            {
                Messages.Remove(m);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Equals(Conversation other)
        {
            return this.Id == other.Id;
        }
    }
}