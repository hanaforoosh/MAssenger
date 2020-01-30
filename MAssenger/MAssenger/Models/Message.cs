using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAssenger.Models
{
    public class Message : AModel, IEquatable<Message>
    {
        public Account From
        {
            get => default;
            set
            {
            }
        }


        public string Content
        {
            get => default;
            set
            {
            }
        }

        public DateTime SentDateTime
        {
            get => default;
            set
            {
            }
        }

        public DateTime ReceivedTime
        {
            get => default;
            set
            {
            }
        }

        public MessageStatus Status
        {
            get => default;
            set
            {
            }
        }

        public Account To
        {
            get => default;
            set
            {
            }
        }

        public bool Equals(Message other)
        {
            throw new NotImplementedException();
        }
    }
}