using System;
using System.Collections.Generic;

namespace MAssenger.Models
{
    public class Bot : Account, IEquatable<Bot>
    {
        private ICollection<Conversation> Conversations = new List<Conversation>();
        public Bot()
        {

        }
        public Bot(UInt64 id, string username, string password)
        {
            Id = id;
            Password = password;
            Username = username;
        }

        public string AccessToken
        {
            get => default;
            set
            {
            }
        }

        public ICollection<string> Commands
        {
            get => default;
            set
            {
            }
        }

        public string CodePath
        {
            get => default;
            set
            {
            }
        }

        public bool Equals(Bot other)
        {
            throw new NotImplementedException();
        }
    }
}