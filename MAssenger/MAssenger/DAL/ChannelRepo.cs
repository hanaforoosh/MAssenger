using MAssenger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAssenger.DAL
{
    public class ChannelRepo : Repo<Channel>

    {
        public ChannelRepo() : base(new DBMySQL()) { }
        public override Channel Create(Channel entity)
        {
            return entity;
        }

        public override bool Delete(Channel entity)
        {
            return true;
        }

        public override bool Delete(AModel id)
        {
            return true;
        }

        public override Channel Read(AModel id)
        {
            return new Channel();
        }

        public override ICollection<Channel> ReadAll()
        {
            return new List<Channel>();
        }

        public override Channel Update(Channel entity)
        {
            return entity;
        }
    }
}