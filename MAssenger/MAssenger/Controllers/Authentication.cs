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
        bool Logout(User user);
        bool IsValid(User user);
        bool IsValid(Session session);
    }

    public class Authentication : IAuthentication
    {
        public Session Login(User user)
        {
            Session session = new Session(1, user, DateTime.MaxValue, LoginType.MAssenger, "A0-51-0B-BB-B8-3C");
            //SessionRepo sessionRepo = new SessionRepo();
            //sessionRepo.Create(session);
            return session; 
        }
        public bool Logout(User user)
        {
            //SessionRepo sessionRepo = new SessionRepo();
            //return sessionRepo.Delete(session);
            return true;
        }
        public bool IsValid(User user)
        {
            return true;
        }
        public bool IsValid(Session session)
        {
            return true;
        }
    }
}