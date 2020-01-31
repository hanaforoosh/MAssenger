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
                if (el.Credential.Username == cr.Username && el.Credential.Password == cr.Password)
                    user = el;
            }
            if (user == null)
            {
                return null;
            }
            Session session = new Session(user, DateTime.MaxValue, LoginType.MAssenger, "A0-51-0B-BB-B8-3C");
            Repo<Session> sessionRepo = new SessionRepo();
            session =sessionRepo.Create(session);
            return session;
        }
        public bool Logout(Session session)
        {
            Repo<Session> sessionRepo = new SessionRepo();
            return sessionRepo.Delete(session);
        }
        public bool Logout(Credential cr)
        {
            Repo<User> ur = new UserRepo();
            ICollection<User> ulist = ur.ReadAll();
            User user = null;
            foreach (var el in ulist)
            {
                if (el.Credential.Username == cr.Username && el.Credential.Password == cr.Password)
                    user = el;
            }
            if (user == null)
            {
                return false;
            }
            Repo<Session> sessionRepo = new SessionRepo();
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
                if (el.Credential.Username == cr.Username && el.Credential.Password == cr.Password)
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
            Repo<Session> sessionRepo = new SessionRepo();
            Session res =sessionRepo.Read(session);

            return (res.Id > 0 );

        }
        public Session SignUp(Credential cr)
        {
            if (Exists(cr.Username))
                return null;
            Repo<User> userRepo = new UserRepo();
            User user = new User(cr);
            userRepo.Create(user);
            Session session = new Session(user, DateTime.MaxValue, LoginType.MAssenger, "A0-51-0B-BB-B8-3C");
            Repo<Session> sessionRepo = new SessionRepo();
            session = sessionRepo.Create(session);
            return session;
        }
        public Session SignUp(User ur)
        {
            if (Exists(ur.Credential.Username))
                return null;
            Repo<User> userRepo = new UserRepo();
            userRepo.Create(ur);
            Session session = new Session(ur, DateTime.MaxValue, LoginType.MAssenger, "A0-51-0B-BB-B8-3C");
            Repo<Session> sessionRepo = new SessionRepo();
            session = sessionRepo.Create(session);
            return session;
        }

        private bool Exists(string userName)
        {
            Repo<User> ur = new UserRepo();
            ICollection<User> ulist = ur.ReadAll();
            User user = null;
            foreach (var el in ulist)
            {
                if (el.Credential.Username == userName)
                    user = el;
            }
            if (user == null)
            {
                return false;
            }
            return true;
        }
    }
}