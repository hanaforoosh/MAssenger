using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAssenger.Models
{
    public class User : AModel
    {
        public User(UInt64 id , string username , string password , string phonenumber)
        {
            Id = id;
            Password = password;
            Username = username;
            PhoneNumber = phonenumber;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }

    }
}