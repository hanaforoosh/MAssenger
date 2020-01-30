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
            new Session(9 , new User(1 , "q" , "qq" , "09160000001") , DateTime.Now , LoginType.google , "1.1.1.1"),
            new Session(8 , new User(2 , "w" , "ww" , "09160000002") , DateTime.Now , LoginType.google , "1.1.1.2"),
            new Session(7 , new User(3 , "e" , "ee" , "09160000003") , DateTime.Now , LoginType.google , "1.1.1.3"),
            new Session(6 , new User(4 , "r" , "rr" , "09160000004") , DateTime.Now , LoginType.google , "1.1.1.4")
        };
        public override bool Create(Session entity)
        {
            sessions.Add(entity);
            return true;
        }

        public override bool Delete(Session entity)
        {
            sessions.Remove(entity);
            return true;
        }

        public override bool Delete(ulong id)
        {
            sessions.Remove(sessions.Find(a => a.Id == id));
            return true;
        }

        public override Session Read(UInt64 id)
        {
            Session _session = sessions.Find(a => a.Id == id);
            return _session;
        }

        public override ICollection<Session> ReadAll()
        {
            return sessions;
        }

        public override bool Update(Session entity)
        {
            Session _session = sessions.Find(a => a.Id == entity.Id);
            if (sessions.Contains(_session))
            {
                sessions.Remove(_session);
            }
            sessions.Add(entity);

            return true;
        }
    }
}