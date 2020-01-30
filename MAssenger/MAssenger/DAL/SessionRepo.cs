using MAssenger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAssenger.DAL
{
    public class SessionRepo : Repo<Session>
    {
        public SessionRepo() : base (new DBMySQL()) { }

        public static List<Session> sessions = new List<Session>()
        {
            new Session(new User(1 , "q" , "qq" , "09160000001") , DateTime.Now , LoginType.google , "1.1.1.1"),
            new Session(new User(2 , "w" , "ww" , "09160000002") , DateTime.Now , LoginType.google , "1.1.1.2"),
            new Session( new User(3 , "e" , "ee" , "09160000003") , DateTime.Now , LoginType.google , "1.1.1.3"),
            new Session( new User(4 , "r" , "rr" , "09160000004") , DateTime.Now , LoginType.google , "1.1.1.4")
        };
        public override Session Create(Session entity)
        {
            sessions.Add(entity);
            entity.Id = UInt64.Parse(sessions.IndexOf(entity).ToString());
            return entity;
        }

        public override bool Delete(Session entity)
        {
            sessions.Remove(entity);
            return true;
        }

        public override bool Delete(AModel aModel)
        {
            sessions.Remove(sessions.Find(a => a.Id == aModel.Id));
            return true;
        }

        public override Session Read(AModel aModel)
        {
            Session _session = sessions.Find(a => a.Id == aModel.Id );
            return _session;
        }

        public override ICollection<Session> ReadAll()
        {
            return sessions;
        }

        public override Session Update(Session entity)
        {
            
            Session _session = sessions.Find(a => a.Id == entity.Id);
            if (sessions.Contains(_session))
            {
                sessions.Remove(_session);
            }
            sessions.Add(entity);

            entity.Id = UInt64.Parse(sessions.IndexOf(entity).ToString());

            return entity;
        }
    }
}