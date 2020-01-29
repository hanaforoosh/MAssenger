using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAssenger.Models
{
    public class Session : AModel
    {
        public string SessionId { get; set; }
        public User User { get; set; }
        public DateTime Exp { get; set; }
        public LoginType LoginType { get; set; }
        public string MacAddesse { get; set; }
        public Session() { }

        public Session(string sessionId, User user, DateTime exp, LoginType loginType, String macAddress)
        {
            SessionId = sessionId;
            User = user;
            Exp = exp;
            this.LoginType = loginType;
            this.MacAddesse = macAddress;
        }

        public bool Equals(Session other)
        {
            return this.Id == other.Id &&
                   this.User == other.User &&
                   this.SessionId == other.SessionId &&
                   this.Exp == other.Exp &&
                   this.LoginType == other.LoginType &&
                   this.MacAddesse == other.MacAddesse;
        }

    }
}