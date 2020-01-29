﻿using MAssenger.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace MAssenger.DAL
{
    public class UserRepo : Repo<User>
    {
        private IDBContext idb = new DBMySQL();
        public override bool Create(User entity)
        {
            idb.WriteData("insert into user (`username` , `phonenumber` , `password`) VALUES  ( '" + entity.Username +
                "' , '" + entity.PhoneNumber + "' , '" + entity.Password + "')  ");

            return true;
        }

        public override bool Delete(User entity)
        {
            idb.WriteData("delete from user where `id` = " + entity.Id + " `username` = " + entity.Username
                + " and `phonenumber` = " + entity.PhoneNumber + " and  `password` = " + entity.Password);
            return true;
        }
        public override bool Delete(UInt64 id)
        {
            idb.WriteData("delete from user where `id` = " + id);
            return true;
        }

        public override User Read(UInt64 id)
        {
            DataTable dataTable = idb.ReadData("select * from user where id = " + id);
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

            DataTable dataTable = idb.ReadData("select * from user ");
            foreach (DataRow dataRow in dataTable.Rows)
            {
                User _user = new User();
                _user.Id = UInt64.Parse(dataRow["id"].ToString());
                _user.Password = dataRow["password"].ToString();
                _user.PhoneNumber = dataRow["phonenumber"].ToString();
                _user.Username = dataRow["username"].ToString();
                users.Add(_user);
            }
            return users;
        }

        public override bool Update(User entity)
        {
            User _user = Read(entity.Id);
            if (_user.Id == 0)
            {
                Create(entity);
            }
            else
            {
                idb.WriteData("update user set  `username` = '" + entity.Username
                + "' , `phonenumber` = '" + entity.PhoneNumber + "' ,  `password` = '" + entity.Password + "' where `id` = " + entity.Id );
            }


            return true;
        }

    }
}