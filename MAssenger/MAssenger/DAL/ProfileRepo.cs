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


        public override Profile Create(Profile entity)
        {
            DBContext = new DBMySQL();
           UInt64 id = DBContext.WriteData("insert into `profile` (`user_id` , `firstname` , `lastname` , `avatar` , `lastseen` , `bio`) " +
                $" values ( {entity.Id}  , '{entity.FirstName}','{entity.LastName}','{entity.Avatar}','{entity.LastSeenStatus}','{entity.Bio}' )");
            entity.Id = id;
            return entity;
        }

        public override bool Delete(Profile entity)
        {
            DBContext.WriteData($"delete from `profile` where `user_id` = {entity.Id}  and `firstname` = {entity.FirstName} and `lastname` = {entity.LastName} " +
                $" and `avatar` = {entity.Avatar} and `lastseen` = {entity.LastSeenStatus} and `bio` = {entity.Bio} ");
            return true;
        }

        public override bool Delete(AModel aModel)
        {
            DBContext.WriteData($"delete from `profile` where `user_id` = {aModel.Id} ");
            return true;
        }

        public override Profile Read(AModel aModel)
        {

            DataTable dataTable = DBContext.ReadData("select * from profile where user_id = " + aModel.Id);
            Profile _profile = new Profile();
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                _profile.Id = UInt64.Parse(dataRow["user_id"].ToString());
                _profile.FirstName = dataRow["firstname"].ToString();
                _profile.LastName = dataRow["lastname"].ToString();
                _profile.Avatar = null;
                _profile.LastSeenStatus = SeenStatus.Online;
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
                    Avatar = null,
                    LastSeenStatus = SeenStatus.Online,
                    LastSeen = DateTime.Parse(dataRow["lastseen"].ToString()),
                    Bio = dataRow["bio"].ToString()
                };

                _profiles.Add(_profile);
            }
            return _profiles;
        }

        public override Profile Update(Profile entity)
        {
            
            Profile _profile = Read(entity);
            if (_profile.Id == 0)
            {
                _profile = Create(entity);
            }
            else
            {
                _profile.Id = DBContext.WriteData($"update  `profile` set `firstname` = {entity.FirstName} and `lastname` = {entity.LastName} " +
                    $" and `avatar` = {entity.Avatar} and `lastseen` = {entity.LastSeenStatus} and `bio` = {entity.Bio}  where `user_id` = {entity.Id}  ");
            }

            return _profile;
        }
    }
}
