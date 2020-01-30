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
        Session Login(User user);
        bool Logout(Session session);
        bool Logout(UInt64 id);
        bool IsValid(User user);
        bool IsValid(Session session);
    }
}