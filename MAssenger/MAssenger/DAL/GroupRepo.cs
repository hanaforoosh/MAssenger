using MAssenger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAssenger.DAL
{
    public class GroupRepo : Repo<Group>

    {
        public GroupRepo() : base(new DBMySQL()) { }
        public override Group Create(Group entity)
        {
            return entity;
        }

        public override bool Delete(Group entity)
        {
            return true;
        }

        public override bool Delete(AModel id)
        {
            return true;
        }

        public override Group Read(AModel id)
        {
            return new Group();
        }

        public override ICollection<Group> ReadAll()
        {
            return new List<Group>();
        }

        public override Group Update(Group entity)
        {
            return entity;
        }
    }
}