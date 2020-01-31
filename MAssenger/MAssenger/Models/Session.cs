using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAssenger.Models
{
    public class Session : AModel, IEquatable<Session>
    {
        public MAssenger.Models.Account User { get; set; }
        public DateTime Exp { get; set; }
        public LoginType LoginType { get; set; }
        public string MacAddesse { get; set; }
        public Session() { }

        public Session(User user, DateTime exp, LoginType loginType, String macAddress)
        {
            Id = UInt64.MaxValue;
            User = user;
            Exp = exp;
            this.LoginType = loginType;
            this.MacAddesse = macAddress;
        }

        public bool Equals(Session other)
        {
            return this.Id == other.Id;
        }
        public bool isValid()
        {
            //check for message digest and Exp
            return true;
        }
    }
}