using MAssenger.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MAssenger.DAL
{
    public class ProfileRepo<T> : IRepo<T> where T : Profile
    {
        public List<Profile> profiles = new List<Profile>(){
            new Profile("a", "aa" , "av1" , DateTime.Now , "bio1"),
            new Profile("b", "bb" , "av2" , DateTime.Now , "bio2"),
            new Profile("c", "cc" , "av3" , DateTime.Now , "bio3"),
            new Profile("d", "dd" , "av4" , DateTime.Now , "bio4"),
        };

        
        public bool Create(T entity)
        {
            profiles.Add(entity);
            return true;
        }

        public bool Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Read(UInt64 id)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> ReadAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}