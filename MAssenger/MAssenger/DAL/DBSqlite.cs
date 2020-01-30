using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Web;

namespace MAssenger.DAL
{
    public class DBSqlite : IDBContext
    {
        public DataTable ReadData(string query)
        {
            SQLiteConnection sql_con = new SQLiteConnection("Data Source=DemoT.db;Version=3;New=False;Compress=True;");
            SQLiteCommand sql_cmd;
            SQLiteDataAdapter DB;
            DataSet DS = new DataSet();
            DataTable DT = new DataTable();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = query;
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            sql_con.Close();
            return DT;
        }

        public UInt64 WriteData(string query)
        {
            var sql_con = new SQLiteConnection("Data Source=DemoT.db;Version=3;New=False;Compress=True;");
            SQLiteCommand sql_cmd;
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = query;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
            return 1;
        }

    }
}