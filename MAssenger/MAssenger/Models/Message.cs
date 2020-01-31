using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAssenger.Models
{
    public class Message : AModel, IEquatable<Message>
    {
        public AModel From { get; set; }
        public AModel To { get; set; }

        public string Content { get; set; }        

        public DateTime SentDateTime { get; set; }

        public DateTime ReceivedTime { get; set; }
        
        public MessageStatus Status { get; set; }

        public Message()
        {
        }

        public bool Equals(Message other)
        {
            throw new NotImplementedException();
        }
    }
}