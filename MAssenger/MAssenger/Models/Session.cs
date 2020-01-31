using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace MAssenger.Models
{
    public class Session : AModel, IEquatable<Session>
    {
        public string Username { get; set; }
        public DateTime Exp { get; set; }
        public LoginType LoginType { get; set; }
        public string MacAddesse { get; set; }
        public Session():base() { }

        public Session(string user, DateTime exp, LoginType loginType, String macAddress)
        {
            Id = UInt64.MaxValue;
            Username = user;
            Exp = exp;
            this.LoginType = loginType;
            this.MacAddesse = macAddress;
        }

        public bool Equals(Session other)
        {
            return this.Id == other.Id;
        }
        public bool IsValid()
        {
            //check for message digest and Exp
            return true;
        }
    }
}