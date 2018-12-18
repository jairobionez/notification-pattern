using DomainNotification.Domain.Interfaces.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainNotification.Domain.Notifications
{
    public abstract class Notification : INotification
    {
        public IList<object> List { get; } = new List<Object>();

        public bool HasNotifications => List.Any();

        public void Add(Description description)
        {
            List.Add(description);
        }

        public bool Includes(Description error)
        {
            return List.Contains(error);
        }
    }
}
