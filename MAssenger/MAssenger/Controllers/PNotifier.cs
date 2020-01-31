using MAssenger.DAL;
using MAssenger.Models;
using System.Collections.Generic;

namespace MAssenger.Controllers
{
    internal class PNotifier : IPushNotifier
    {
        public void Broadcast(Message m)
        {
            Repo<Account> userRepo = new AccountRepo();
            ICollection<Account> users = userRepo.ReadAll();
            foreach (var user in users)
            {
                m.To = user;
                user.AddMessageToInbox(m);
            }
        }

        public void notify(Message m)
        {
        }

        public void ResendNotification(Message m)
        {
        }
    }
}