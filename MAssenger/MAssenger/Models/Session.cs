using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAssenger.Models
{
    public class Session : AModel
    {
        public Session() { }

        public Session(string sessionId , User user ,DateTime exp , LoginType loginType , String macAddress)
        {
            SessionId = sessionId;
            this.user = user;
            Exp = exp;
            this.loginType = loginType;
            MacAddress = macAddress;
        }

        public string SessionId { get; set; }
        public User user{ get; set; }
        public DateTime Exp { get; set; }
        public LoginType loginType { get; set; }
        public string MacAddress { get; set; }

    }
}