using MAssenger.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Web;

namespace MAssenger.DAL
{
    public class AccountRepo : Repo<Account>
    {
        public AccountRepo() : base(new DBMySQL()) { }


        public override Account Create(Account entity)
        {
            DBContext = new DBMySQL();
           UInt64 id = DBContext.WriteData("insert into `profile` (`user_id` , `firstname` , `lastname` , `avatar` , `lastseen` , `bio`) " +
                $" values ( {entity.Id}  , '{entity.FirstName}','{entity.LastName}','{entity.Avatar}','{entity.LastSeenStatus}','{entity.Bio}' )");
            entity.Id = id;
            return entity;
        }

        public override bool Delete(Account entity)
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

        public override Account Read(AModel aModel)
        {

            DataTable dataTable = DBContext.ReadData("select * from profile where user_id = " + aModel.Id);
            Account _Account = new Account();
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                _Account.Id = UInt64.Parse(dataRow["user_id"].ToString());
                _Account.FirstName = dataRow["firstname"].ToString();
                _Account.LastName = dataRow["lastname"].ToString();
                _Account.Avatar = null;
                _Account.LastSeenStatus = SeenStatus.Online;
                _Account.LastSeen = DateTime.Parse(dataRow["username"].ToString());
                _Account.Bio = dataRow["bio"].ToString();

            }


            return _Account;
        }

        public override ICollection<Account> ReadAll()
        {
            DataTable dataTable = DBContext.ReadData("select * from profile ");
            List<Account> _accounts = new List<Account>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                Account _account = new Account
                {
                    Id = UInt64.Parse(dataRow["user_id"].ToString()),
                    FirstName = dataRow["firstname"].ToString(),
                    LastName = dataRow["lastname"].ToString(),
                    Avatar = null,
                    LastSeenStatus = SeenStatus.Online,
                    LastSeen = DateTime.Parse(dataRow["lastseen"].ToString()),
                    Bio = dataRow["bio"].ToString()
                };

                _accounts.Add(_account);
            }
            return _accounts;
        }

        public override Account Update(Account entity)
        {

            Account _profile = Read(entity);
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
