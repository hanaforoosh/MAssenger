using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAssenger.Models
{
    public class User : AModel,IEquatable<User>
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public User()
        {

        }
        public User(UInt64 id, string username, string password, string phonenumber)
        {
            Id = id;
            Password = password;
            Username = username;
            PhoneNumber = phonenumber;
        }
        public bool Equals(User other)
        {
            return this.Id == other.Id &&
                   this.Username == other.Username &&
                   this.Password == other.Password &&
                   this.PhoneNumber == other.PhoneNumber;
        }
    }
}