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
            if (entity.Members.Count > 1 || entity.conversationType != ConversationType.DoubleChat)
            {
                // wrong
            }

            IList iListMessages = entity.Messages as IList;
            Message message = (Message)iListMessages[0];

            DataTable dataTable = DBContext.ReadData($"SELECT * FROM conversation as c1, conversation as c2 WHERE c1.amodel_id = {message.From} AND c2.amodel_id = {message.To} AND c1.`type` = '{entity.conversationType}' AND c2.`type` = '{entity.conversationType}' and c1.conversation = c2.conversation");

            if (dataTable.Rows.Count > 0)
            {   // conversation exists
                DataRow dataRow = dataTable.Rows[0];
                DBContext.WriteData("insert into `message` ( `frome` , `to` ,  `resivedtime` , `senttime` , `status` , `content` , `conversation_id`)" +
                    $"values ({message.From} , {message.To}, {message.ReceivedTime} , {message.SentDateTime} , {message.Status} ,{message.Content}, {dataRow["conversation_id"]})");
            }
            else
            {   // create conversation
                DataTable dt = DBContext.ReadData("select max(`conversation`) as maxid from conversation");
                int newConversationId = -1;
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    newConversationId = int.Parse(dr["maxid"].ToString()) + 1;
                }
                else
                {
                    newConversationId = 1;
                }
                DBContext.WriteData("insert into conversation (`amodel_id` , `conversation` , `type`) " +
                    $"values({message.From} , {newConversationId} , {entity.conversationType})");
                DBContext.WriteData("insert into conversation (`amodel_id` , `conversation` , `type`) " +
                    $"values({message.To} , {newConversationId} , {entity.conversationType})");

                DBContext.WriteData("insert into `message` ( `frome` , `to` ,  `resivedtime` , `senttime` , `status` , `content` , `conversation_id`)" +
                    $"values ({message.From} , {message.To}, {message.ReceivedTime} , {message.SentDateTime} , {message.Status} ,{message.Content}, {newConversationId})");

            }




            //foreach (Message message in entity.Messages)
            //{

            //}


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