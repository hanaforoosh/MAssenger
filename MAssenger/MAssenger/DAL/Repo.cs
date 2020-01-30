using MAssenger.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MAssenger.DAL
{
    public abstract class Repo<T> where T : AModel
    {
        public IDBContext DBContext{ set; get; }

        public abstract T Create(T entity);
        public abstract T Read(AModel id);
        public abstract ICollection<T> ReadAll();
        public abstract T Update(T entity);
        public abstract bool Delete(T entity);
        public abstract bool Delete(AModel id);

        public Repo(IDBContext dBContext)
        {
            DBContext = dBContext;
        }
    }
}