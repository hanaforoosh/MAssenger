using MAssenger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAssenger.DAL
{
    public class MessageRepo : Repo<Message>
    {
        public MessageRepo() : base(new DBMySQL()) { }

        public override Message Create(Message entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(Message entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(AModel aModel)
        {
            throw new NotImplementedException();
        }

        public override Message Read(AModel aModel)
        {
            throw new NotImplementedException();
        }

        public override ICollection<Message> ReadAll()
        {
            throw new NotImplementedException();
        }

        public override Message Update(Message entity)
        {
            throw new NotImplementedException();
        }
    }
}