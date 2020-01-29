using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAssenger.Models
{
    public class Profile : AModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Avatar { get; set; }
        public DateTime LastSeen { get; set; }
        public string Bio { get; set; }
        public Profile() { }

        public Profile(string firstName, string lastName, string avatar, DateTime lastSeen, string bio)
        {
            FirstName = firstName;
            LastName = lastName;
            Avatar = avatar;
            LastSeen = lastSeen;
            Bio = bio;
        }
        public bool Equals(Profile other)
        {
            return this.Id == other.Id &&
                   this.FirstName == other.FirstName &&
                   this.LastName == other.LastName &&
                   this.Avatar == other.Avatar &&
                   this.LastSeen == other.LastSeen &&
                   this.Bio == other.Bio;
        }

    }
}