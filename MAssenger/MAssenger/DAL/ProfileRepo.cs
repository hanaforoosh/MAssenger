using MAssenger.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MAssenger.DAL
{
    public class ProfileRepo : Repo<Profile>
    {
        public List<Profile> profiles = new List<Profile>(){
            new Profile("a", "aa" , "av1" , DateTime.Now , "bio1"),
            new Profile("b", "bb" , "av2" , DateTime.Now , "bio2"),
            new Profile("c", "cc" , "av3" , DateTime.Now , "bio3"),
            new Profile("d", "dd" , "av4" , DateTime.Now , "bio4"),
        };


        public override bool Create(Profile entity)
        {
            profiles.Add(entity);
            return true;
        }

        public override bool Delete(Profile entity)
        {
            profiles.Remove(entity);
            return true;
        }

        public override bool Delete(UInt64 id)
        {
            profiles.Remove(profiles.Find(a => a.Id == id));
            return true;
        }

        public override Profile Read(UInt64 id)
        {
            Profile _profile = profiles.Find(a => a.Id == id);
            return _profile;
        }

        public override ICollection<Profile> ReadAll()
        {
            return profiles;
        }

        public override bool Update(Profile entity)
        {
            Profile _profile = profiles.Find(a => a.Id == entity.Id);
            if (profiles.Contains(_profile))
            {
                profiles.Remove(_profile);
            }
            profiles.Add(entity);

            return true;
        }
    }
}
