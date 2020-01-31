using MAssenger.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace MAssenger.DAL
{
    public class UserRepo : Repo<User>
    {
        public UserRepo() : base(new DBMySQL()) { }

        public override User Create(User entity)
        {
            UInt64 amodelId = DBContext.WriteData(" insert into amodel (`type`) values ('user') ");

            DBContext.WriteData($"insert into user (`phonenumber` , `amodel_id` , `lastseen`) values ( '{entity.PhoneNumber}' , { amodelId } , '{DateTime.Now}')");

            DBContext.WriteData("insert into account ( `amodel_id` , `avatar` , `bio` , `firstname` , `lastname` , `lastseenstatus` , `username` , `password`)" +
                $" values ( {amodelId} ,'{entity.Avatar}','{entity.Bio}','{entity.FirstName}' ,'{entity.LastName}','{entity.LastSeenStatus}','{entity.Credential.Username}','{entity.Credential.Password}')");

            entity.Id = amodelId;
            return entity;
        }

        public override bool Delete(User entity)
        {
            DBContext.WriteData("delete from user where `amodel_id` = " + entity.Id);
            DBContext.WriteData("delete from account where `amodel_id` = " + entity.Id);
            DBContext.WriteData("delete from amodel where `id` = " + entity.Id);
            return true;
        }
        public override bool Delete(AModel aModel)
        {
            DBContext.WriteData("delete from user where `amodel_id` = " + aModel.Id);
            DBContext.WriteData("delete from account where `amodel_id` = " + aModel.Id);
            DBContext.WriteData("delete from amodel where `id` = " + aModel.Id);
            return true;
        }

        public override User Read(AModel aModel)
        {
            DataTable dataTable = DBContext.ReadData("SELECT * FROM	amodel inner join account on amodel.id = account.amodel_id inner join user on amodel.id = user.amodel_id where amodel.id =  " + aModel.Id);
            User _users = new User();
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                _users.Id = UInt64.Parse(dataRow["id"].ToString());
                _users.Credential.Password = dataRow["password"].ToString();
                _users.Credential.Username = dataRow["username"].ToString();
                _users.PhoneNumber = dataRow["phonenumber"].ToString();
                _users.Avatar = null; // dataRow["Avatar"].ToString();
                _users.Bio = dataRow["Bio"].ToString();
                _users.FirstName = dataRow["FirstName"].ToString();
                _users.LastName = dataRow["LastName"].ToString();
                _users.LastSeen = DateTime.Now; // Datetime.Parse(dataRow["LastSeen"].ToString());
                _users.LastSeenStatus = SeenStatus.Online; // dataRow["LastSeenStatus"].ToString();
            }
            return _users;
        }

        public override ICollection<User> ReadAll()
        {
            List<User> users = new List<User>();

            DataTable dataTable = DBContext.ReadData("SELECT * FROM	amodel inner join account on amodel.id = account.amodel_id inner join user on amodel.id = user.amodel_id ");
            foreach (DataRow dataRow in dataTable.Rows)
            {
                User _user = new User
                {

                    Id = UInt64.Parse(dataRow["id"].ToString()),
                    PhoneNumber = dataRow["phonenumber"].ToString(),
                    Avatar = null, // dataRow["Avatar"].ToString();
                    Bio = dataRow["Bio"].ToString(),
                    FirstName = dataRow["FirstName"].ToString(),
                    LastName = dataRow["LastName"].ToString(),
                    LastSeen = DateTime.Now , // Datetime.Parse(dataRow["LastSeen"].ToString());
                    LastSeenStatus = SeenStatus.Online // dataRow["LastSeenStatus"].ToString();
            };
                _user.Credential.Username = dataRow["username"].ToString();
                _user.Credential.Password = dataRow["password"].ToString();
                users.Add(_user);
            }
            return users;
        }

        public override User Update(User entity)
        {
            User _user = Read(entity);
            if (_user.Id == 0)
            {
                _user = Create(entity);
            }
            else
            {
                //_user.Id = DBContext.WriteData("update user set  `username` = '" + entity.Username
                //+ "' , `phonenumber` = '" + entity.PhoneNumber + "' ,  `password` = '" + entity.Password + "' where `id` = " + entity.Id );
            }


            return _user;
        }

    }
}