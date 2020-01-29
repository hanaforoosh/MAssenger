using System;
using System.Data;


namespace MAssenger.DAL
{
    public interface IDBContext
    {
        void WriteData(string query);
        DataTable ReadData(string query);
    }
}