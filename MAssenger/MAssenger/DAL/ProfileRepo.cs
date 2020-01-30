using MAssenger.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Web;

namespace MAssenger.DAL
{
    public class ProfileRepo : Repo<Profile>
    {
        public ProfileRepo() : base(new DBMySQL()) { }


        public override bool Create(Profile entity)
        {
            DBContext = new DBMySQL();
            DBContext.WriteData("insert into `profile` (`user_id` , `firstname` , `lastname` , `avatar` , `lastseen` , `bio`) " +
                $" values ( {entity.Id}  , '{entity.FirstName}','{entity.LastName}','{entity.Avatar}','{entity.LastSeen}','{entity.Bio}' )");
            return true;
        }

        public override bool Delete(Profile entity)
        {
            DBContext.WriteData($"delete from `profile` where `user_id` = {entity.Id}  and `firstname` = {entity.FirstName} and `lastname` = {entity.LastName} " +
                $" and `avatar` = {entity.Avatar} and `lastseen` = {entity.LastSeen} and `bio` = {entity.Bio} ");
            return true;
        }

        public override bool Delete(UInt64 id)
        {
            DBContext.WriteData($"delete from `profile` where `user_id` = {id} ");
            return true;
        }

        public override Profile Read(UInt64 id)
        {

            DataTable dataTable = DBContext.ReadData("select * from profile where user_id = " + id);
            Profile _profile = new Profile();
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                _profile.Id = UInt64.Parse(dataRow["user_id"].ToString());
                _profile.FirstName = dataRow["firstname"].ToString();
                _profile.LastName = dataRow["lastname"].ToString();
                _profile.Avatar = dataRow["avatar"].ToString();
                _profile.LastSeen = DateTime.Parse(dataRow["username"].ToString());
                _profile.Bio = dataRow["bio"].ToString();

            }


            return _profile;
        }

        public override ICollection<Profile> ReadAll()
        {
            DataTable dataTable = DBContext.ReadData("select * from profile ");
            List<Profile> _profiles = new List<Profile>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                Profile _profile = new Profile
                {
                    Id = UInt64.Parse(dataRow["user_id"].ToString()),
                    FirstName = dataRow["firstname"].ToString(),
                    LastName = dataRow["lastname"].ToString(),
                    Avatar = dataRow["avatar"].ToString(),
                    LastSeen = DateTime.Parse(dataRow["lastseen"].ToString()),
                    Bio = dataRow["bio"].ToString()
                };

                _profiles.Add(_profile);
            }
            return _profiles;
        }

        public override bool Update(Profile entity)
        {
            Profile _profile = Read(entity.Id);
            if (_profile.Id == 0)
            {
                Create(entity);
            }
            else
            {
                DBContext.WriteData($"update  `profile` set `firstname` = {entity.FirstName} and `lastname` = {entity.LastName} " +
                    $" and `avatar` = {entity.Avatar} and `lastseen` = {entity.LastSeen} and `bio` = {entity.Bio}  where `user_id` = {entity.Id}  ");
            }

            return true;
        }
    }
}
