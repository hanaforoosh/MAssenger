using MAssenger.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MAssenger.DAL
{
    public class DoubleChatRepo : Repo<DoubleChat>
    {
        public DoubleChatRepo() : base(new DBMySQL()) { }

        public override DoubleChat Create(DoubleChat entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(DoubleChat entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(AModel id)
        {
            throw new NotImplementedException();
        }

        public override DoubleChat Read(AModel id)
        {
            throw new NotImplementedException();
        }

        public override ICollection<DoubleChat> ReadAll()
        {
            throw new NotImplementedException();
        }

        public override DoubleChat Update(DoubleChat entity)
        {
            throw new NotImplementedException();
        }
    }
}