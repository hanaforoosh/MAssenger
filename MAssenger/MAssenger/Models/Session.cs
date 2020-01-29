using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAssenger.Models
{
    public class Session : AModel
    {
        private string sessionId;
        private User user;
        private DateTime exp;
        private LoginType loginType;
        private string MacAddesse;

    }
}