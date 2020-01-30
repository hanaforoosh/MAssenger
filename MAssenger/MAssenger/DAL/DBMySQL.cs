using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace MAssenger.DAL
{
    public class DBMySQL : IDBContext
    {
        public DataTable ReadData(string query)
        {
            DataTable dataTable = new DataTable() ;
            string connection = @"server=localhost;uid=root;password='';database=massenger;port=3306;charset=utf8;Convert Zero Datetime=True";
            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter
            {
                SelectCommand = new MySqlCommand(query, conn)
            };
            adapter.Fill(dataTable);
            conn.Close();
            return dataTable;
        }

        public UInt64 WriteData(string query)
        {
            string connString = @"server=localhost;uid=root;password='';database=massenger;port=3306;charset=utf8";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = query;
            comm.ExecuteNonQuery();
            conn.Close();
            return 1;
        }
    }
}