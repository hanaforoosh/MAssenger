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
           DBContext.WriteData("insert into account (`amodel_id` , `avatar` , `bio` , `firstname` , `lastname` , `lastseenstatus` , `username` , `password`)"
               + $" values({entity.Id} ,'{entity.Avatar}' , '{entity.Bio}' , '{entity.FirstName}' , '{entity.LastName}' , '{entity.LastSeenStatus}' , '{entity.Credential.Username}' , '{entity.Credential.Password}' )");
            
            return entity;
        }

        public override bool Delete(Account entity)
        {
            DBContext.WriteData($"delete from `account` where `amodel_id` = {entity.Id} ");
            return true;
        }

        public override bool Delete(AModel aModel)
        {
            DBContext.WriteData($"delete from `account` where `amodel_id` = {aModel.Id} ");
            return true;
        }

        public override Account Read(AModel aModel)
        {

            DataTable dataTable = DBContext.ReadData("select * from account where amodel_id = " + aModel.Id);
            Account _account = new Account();
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                _account.Id = UInt64.Parse(dataRow["user_id"].ToString());
                _account.FirstName = dataRow["firstname"].ToString();
                _account.LastName = dataRow["lastname"].ToString();
                _account.Avatar = null;
                _account.LastSeenStatus = SeenStatus.Online;
                _account.LastSeen = DateTime.Parse(dataRow["username"].ToString());
                _account.Bio = dataRow["bio"].ToString();

            }


            return _account;
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
