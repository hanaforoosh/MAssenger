using MAssenger.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAssenger.DAL
{
    public class DoubleChatRepo : Repo<DoubleChat>
    {
        public DoubleChatRepo() : base(new DBMySQL()) { }

        public override DoubleChat Create(DoubleChat entity)
        {
            if (entity.Members.Count > 1 || entity.conversationType != ConversationType.DoubleChat)
            {
                // wrong
            }
            
            IList iListMessages = entity.Messages as IList;
            foreach (Message message in entity.Messages)
            {

            }


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