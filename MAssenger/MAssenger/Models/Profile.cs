using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace MAssenger.Models
{
    public class Profile : AModel, IEquatable<Profile>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Image Avatar { get; set; }
        public SeenStatus LastSeenStatus { get; set; }
        public string Bio { get; set; }

        public string VisibleId
        {
            get => default;
            set
            {
            }
        }

        public DateTime LastSeen
        {
            get => default;
            set
            {
            }
        }

        public Profile() { }

        public bool Receiver(Profile other)
        {
            return this.Id == other.Id &&
                   this.FirstName == other.FirstName &&
                   this.LastName == other.LastName &&
                   this.Avatar == other.Avatar &&
                   this.LastSeenStatus == other.LastSeenStatus &&
                   this.Bio == other.Bio;
        }

        public bool Equals(Profile other)
        {
            throw new NotImplementedException();
        }
    }
}