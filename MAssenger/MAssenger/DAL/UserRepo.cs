﻿using MAssenger.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MAssenger.DAL
{
    public class UserRepo: IRepo<User>
    {
        public static List<User> users = new List<User>() { 
            new User(1 , "a" , "aa" , "09120000001"),
            new User(2 , "b" , "bb" , "09120000002"),
            new User(3 , "c" , "cc" , "09120000003"),
            new User(4 , "d" , "dd" , "09120000004"),
            new User(5 , "e" , "ee" , "09120000005"),
            new User(6 , "f" , "ff" , "09120000006")
        };
  
        public bool Create(User entity)
        {
            users.Add(entity);
            return true;
        }

        public bool Delete(User entity)
        {
            users.Remove(entity);
            return true;
        }

        public User Read(UInt64 id)
        {
            User _user =  users.Find(a => a.Id == id);

            return _user;
        }

        public ICollection<User> ReadAll()
        {
            return users;
        }

        public bool Update(User entity)
        {
            User _user = users.Find(a => a.Id == entity.Id);
            if (users.Contains(_user))
            {
                users.Remove(_user);             
            }
            users.Add(entity);

            return true;
        }

    }
}