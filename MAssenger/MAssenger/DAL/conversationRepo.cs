using MAssenger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAssenger.DAL
{
    public class ConversationRepo : Repo<Conversation>
    {
        public ConversationRepo() : base(new DBMySQL()) { }

        public override Conversation Create(Conversation entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(Conversation entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(AModel id)
        {
            throw new NotImplementedException();
        }

        public override Conversation Read(AModel id)
        {
            throw new NotImplementedException();
        }

        public override ICollection<Conversation> ReadAll()
        {
            throw new NotImplementedException();
        }

        public override Conversation Update(Conversation entity)
        {
            throw new NotImplementedException();
        }
    }
}