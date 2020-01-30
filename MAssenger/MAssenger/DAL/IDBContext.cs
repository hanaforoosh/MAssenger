using System;
using System.Data;


namespace MAssenger.DAL
{
    public interface IDBContext
    {
        UInt64 WriteData(string query);
        DataTable ReadData(string query);
    }
}