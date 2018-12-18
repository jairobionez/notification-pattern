using DomainNotification.Domain.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainNotification.Domain.Interfaces.Notifications
{
    public interface INotification
    {
        IList<Object> List { get; }
        bool HasNotifications { get; }
        bool Includes(Description error);
        void Add(Description description);
    }
}
