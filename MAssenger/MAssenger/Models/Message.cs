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
        Message()
        {
             From = new User();
             To = new Conversation();
            
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


        public bool Equals(Message other)
        {
            throw new NotImplementedException();
        }
    }
}