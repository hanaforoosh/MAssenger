using MAssenger.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MAssenger.DAL
{
    public class ConversationRepo : Repo<Conversation>
    {
        public ConversationRepo() : base(new DBMySQL()) { }

        public override Conversation Create(Conversation entity)
        {
            IList iListMessages = entity.Messages as IList;
            Message message = (Message)iListMessages[0];

            DataTable dataTable = DBContext.ReadData($"SELECT c1.* FROM conversation as c1, conversation as c2 WHERE c1.amodel_id = {message.From.Id} AND c2.amodel_id = {message.To.Id} AND c1.`type` = '{entity.conversationType}' AND c2.`type` = '{entity.conversationType}' and c1.conversation = c2.conversation");


            if (dataTable.Rows.Count > 0)
            {   // conversation exists
                DataRow dataRow = dataTable.Rows[0];
                DBContext.WriteData("insert into `message` ( `from` , `to` ,  `resivedtime` , `senttime` , `status` , `content` , `conversation_id`)" +
                    $"values ({message.From.Id} , {message.To.Id}, '{message.ReceivedTime}' , '{message.SentDateTime}' , '{message.Status}' ,'{message.Content}', {dataRow[2]})");
            }
            else
            {   // create conversation
                DataTable dt = DBContext.ReadData("select max(`conversation`) as maxid from conversation");
                int newConversationId = -1;
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    if (!dr["maxid"].ToString().Equals(""))
                        newConversationId = int.Parse(dr["maxid"].ToString()) + 1;
                    else 
                        newConversationId = 1;
                }
                else
                {
                    newConversationId = 1;
                }
                DBContext.WriteData("insert into conversation (`amodel_id` , `conversation` , `type`) " +
                    $"values({message.From.Id} , {newConversationId} , '{entity.conversationType}')");
                DBContext.WriteData("insert into conversation (`amodel_id` , `conversation` , `type`) " +
                    $"values({message.To.Id} , {newConversationId} , '{entity.conversationType}')");

                DBContext.WriteData("insert into `message` ( `from` , `to` ,  `resivedtime` , `senttime` , `status` , `content` , `conversation_id`)" +
                    $"values ({message.From.Id} , {message.To.Id}, '{message.ReceivedTime}' , '{message.SentDateTime}' , '{message.Status}' ,'{message.Content}', '{newConversationId}')");

            }


            return entity;
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