using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using MAssenger.Models;
using System.Collections.Generic;

namespace MAssenger
{
    public class Group : Conversation
    {
        public Account Admin
        {
            get => default;
            set
            {
            }
        }

        public Message PinnedMessage
        {
            get => default;
            set
            {
            }
        }
    }

    public class Channel : Conversation
    {
        private System.Collections.Generic.ICollection<Account> Authors = new List<Account>();

        public override bool NewMessage(Message m)
        {
            Messages.Add(m);
            return true;
        }
    }
}