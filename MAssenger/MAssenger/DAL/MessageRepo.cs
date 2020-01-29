using MAssenger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAssenger.DAL
{
    public class MessageRepo : IRepo<Message>
    {
        public bool Create(Message entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Message entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ulong id)
        {
            throw new NotImplementedException();
        }

        public Message Read(ulong id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Message> ReadAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Message entity)
        {
            throw new NotImplementedException();
        }
    }
}