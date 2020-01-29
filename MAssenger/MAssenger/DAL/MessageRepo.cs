using MAssenger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAssenger.DAL
{
    public class MessageRepo : Repo<Message>
    {
        public override bool Create(Message entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(Message entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(ulong id)
        {
            throw new NotImplementedException();
        }

        public override Message Read(ulong id)
        {
            throw new NotImplementedException();
        }

        public override ICollection<Message> ReadAll()
        {
            throw new NotImplementedException();
        }

        public override bool Update(Message entity)
        {
            throw new NotImplementedException();
        }
    }
}