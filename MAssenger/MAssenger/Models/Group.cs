using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using MAssenger.Models;

namespace MAssenger.Models
{
    public class Group : Conversation, IEquatable<Group>
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
        public bool Equals(Group other)
        {
            return this.Id == other.Id;
        }
    }
}