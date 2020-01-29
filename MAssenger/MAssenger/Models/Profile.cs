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
    }
}