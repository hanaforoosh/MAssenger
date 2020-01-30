using MAssenger.DAL;
using MAssenger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MAssenger.Controllers
{
    public interface IAuthentication
    {
        Session Login(Credential cr);
        bool Logout(Session session);
        bool Logout(Credential cr);
        bool IsValid(Credential cr);
        bool IsValid(Session session);
    }
}