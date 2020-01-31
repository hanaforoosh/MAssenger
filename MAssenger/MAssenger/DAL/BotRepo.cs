using MAssenger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAssenger.DAL
{
    public class BotRepo : Repo<Bot>
    {
        public BotRepo() : base(new DBMySQL()) { }

        public override Bot Create(Bot entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(Bot entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(AModel id)
        {
            throw new NotImplementedException();
        }

        public override Bot Read(AModel id)
        {
            throw new NotImplementedException();
        }

        public override ICollection<Bot> ReadAll()
        {
            throw new NotImplementedException();
        }

        public override Bot Update(Bot entity)
        {
            throw new NotImplementedException();
        }
    }
}