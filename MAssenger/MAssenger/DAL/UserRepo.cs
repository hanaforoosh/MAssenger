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

            DBContext.WriteData($"insert into user (`phonenumber` , `amodel_id` ) values ( '123' , { amodelId } )");

            DBContext.WriteData("insert into account ( `amodel_id` , `avatar` , `bio` , `firstname` , `lastname` , `lastseen` , `username` , `password`)"+
                $" values ( {amodelId} ,{entity.Avatar},{entity.Bio},{entity.FirstName} ,{entity.LastName},{entity.LastSeen},{entity.Credential.Username},{entity.Credential.Password})");

            entity.Id = amodelId;
            return entity;
        }

        public override bool Delete(User entity)
        {
            DBContext.WriteData("delete from user where `id` = " + entity.Id + " `username` = " + entity.Username
                + " and `phonenumber` = " + entity.PhoneNumber + " and  `password` = " + entity.Password);
            return true;
        }
        public override bool Delete(AModel aModel)
        {
            DBContext.WriteData("delete from user where `id` = " + aModel.Id);
            return true;
        }

        public override User Read(AModel aModel)
        {
            DataTable dataTable = DBContext.ReadData("select * from user where id = " + aModel.Id);
            User _users = new User();
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                _users.Id = UInt64.Parse(dataRow["id"].ToString());
                _users.Password = dataRow["password"].ToString();
                _users.PhoneNumber = dataRow["phonenumber"].ToString();
                _users.Username = dataRow["username"].ToString();

            }
            return _users;
        }

        public override ICollection<User> ReadAll()
        {
            List<User> users = new List<User>();

            DataTable dataTable = DBContext.ReadData("select * from user ");
            foreach (DataRow dataRow in dataTable.Rows)
            {
                User _user = new User
                {
                    Id = UInt64.Parse(dataRow["id"].ToString()),
                    Password = dataRow["password"].ToString(),
                    PhoneNumber = dataRow["phonenumber"].ToString(),
                    Username = dataRow["username"].ToString()
                };
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
                _user.Id = DBContext.WriteData("update user set  `username` = '" + entity.Username
                + "' , `phonenumber` = '" + entity.PhoneNumber + "' ,  `password` = '" + entity.Password + "' where `id` = " + entity.Id );
            }


            return _user;
        }

    }
}