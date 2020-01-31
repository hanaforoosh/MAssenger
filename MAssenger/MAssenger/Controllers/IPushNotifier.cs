using MAssenger.Models;

namespace MAssenger.Controllers
{
    internal interface IPushNotifier
    {
        void notify(Message m);
        void ResendNotification(Message m);
        void Broadcast(Message m);
    }
}