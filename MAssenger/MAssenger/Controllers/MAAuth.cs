using MAssenger.DAL;
using MAssenger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MAssenger.Controllers
{
    public class MAAuth : IAuthentication
    {
        public Session Login(Credential cr)
        {
            Repo<User> ur = new UserRepo();
            ICollection<User> ulist = ur.ReadAll();
            User user = null;
            foreach (var el in ulist)
            {
                if (el.Username == cr.Username && el.Password == cr.Paswword)
                    user = el;
            }
            if (user == null)
            {
                return null;
            }
            Session session = new Session(user, DateTime.MaxValue, LoginType.MAssenger, "A0-51-0B-BB-B8-3C");
            SessionRepo sessionRepo = new SessionRepo();
            session =sessionRepo.Create(session);
            return session;
        }
        public bool Logout(Session session)
        {
            SessionRepo sessionRepo = new SessionRepo();
            return sessionRepo.Delete(session);
        }
        public bool Logout(Credential cr)
        {
            Repo<User> ur = new UserRepo();
            ICollection<User> ulist = ur.ReadAll();
            User user = null;
            foreach (var el in ulist)
            {
                if (el.Username == cr.Username && el.Password == cr.Paswword)
                    user = el;
            }
            if (user == null)
            {
                return false;
            }
            SessionRepo sessionRepo = new SessionRepo();
            ICollection<Session> sessions = sessionRepo.ReadAll();
            Session session = null;
            foreach (var el in sessions)
            {
                if (el.User == user)
                    session = el;
            }
            if (session == null)
            {
                return false;
            }

            return sessionRepo.Delete(session);
        }
        public bool IsValid(Credential cr)
        {
            Repo<User> ur = new UserRepo();
            ICollection<User> ulist = ur.ReadAll();
            User user = null;
            foreach (var el in ulist)
            {
                if (el.Username == cr.Username && el.Password == cr.Paswword)
                    user = el;
            }
            if (user == null)
            {
                return false;
            }
            return true;
        }
        public bool IsValid(Session session)
        {
            SessionRepo sessionRepo = new SessionRepo();
            int res =sessionRepo.Read(session);
            return !(res == -1);

        }
    }
}