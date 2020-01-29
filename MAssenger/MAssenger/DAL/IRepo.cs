using MAssenger.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MAssenger.DAL
{
    public interface IRepo<T> where T : AModel
    {
        bool Create(T entity);
        T Read(UInt64 id);
        Collection<T> ReadAll();
        bool Update(T entity);
        bool Delete(T entity);
    }
}