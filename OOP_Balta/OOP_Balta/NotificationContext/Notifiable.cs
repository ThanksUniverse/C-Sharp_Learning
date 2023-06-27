using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Balta.NotificationContext
{
    public abstract class Notifiable
    {
        public Notifiable()
        {
            Notifications = new List<Notification>();
        }
        public List<Notification> Notifications { get; set; }
        public void AddNotification(Notification notification)
        {
            Notifications.Add(notification);
        }
        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            Notifications.AddRange(notifications);
        }

        public bool IsInvalid => Notifications.Any();
    }
}
