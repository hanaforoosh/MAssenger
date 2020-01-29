using MAssenger.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MAssenger.DAL
{
    public class UserRepo<T> : IRepo<T> where T : User
    {
        public List<User> users = new List<User>() { 
            new User(1 , "a" , "aa" , "09120000001"),
            new User(2 , "b" , "bb" , "09120000002"),
            new User(3 , "c" , "cc" , "09120000003"),
            new User(4 , "d" , "dd" , "09120000004"),
            new User(5 , "e" , "ee" , "09120000005"),
            new User(6 , "f" , "ff" , "09120000006")
        };

       

        public bool Create(T entity)
        {
            users.Add(entity);
            return true;
        }

        public bool Delete(T entity)
        {
            users.Remove(entity);
            return true;
        }

        public T Read(UInt64 id)
        {
            User aaaa =  users.Find(a => a.Id == id);
            throw new NotImplementedException();
        }

        public Collection<T> ReadAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}