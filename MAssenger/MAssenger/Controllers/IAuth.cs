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
        Session SignUp(Credential cr);
        bool DeleteAccount(Credential cr);
    }

    public class  GoogleAuth: IAuthentication
    {
        Session IAuthentication.Login(Credential cr)
        {
            throw new NotImplementedException();
        }

        bool IAuthentication.Logout(Session session)
        {
            throw new NotImplementedException();
        }

        bool IAuthentication.Logout(Credential cr)
        {
            throw new NotImplementedException();
        }

        bool IAuthentication.IsValid(Credential cr)
        {
            throw new NotImplementedException();
        }

        bool IAuthentication.IsValid(Session session)
        {
            throw new NotImplementedException();
        }
        public Session SignUp(Credential cr)
        {
            throw new NotImplementedException();
        }


        public bool DeleteAccount(Credential cr)
        {
            throw new NotImplementedException();
        }
    }

    public class FacebookAuth : IAuthentication
    {
        Session IAuthentication.Login(Credential cr)
        {
            throw new NotImplementedException();
        }

        bool IAuthentication.Logout(Session session)
        {
            throw new NotImplementedException();
        }

        bool IAuthentication.Logout(Credential cr)
        {
            throw new NotImplementedException();
        }

        bool IAuthentication.IsValid(Credential cr)
        {
            throw new NotImplementedException();
        }

        bool IAuthentication.IsValid(Session session)
        {
            throw new NotImplementedException();
        }

        public Session SignUp(Credential cr)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAccount(Credential cr)
        {
            throw new NotImplementedException();
        }
    }
}