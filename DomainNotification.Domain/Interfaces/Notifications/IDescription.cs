using System;
using System.Collections.Generic;
using System.Text;

namespace DomainNotification.Domain.Interfaces.Notifications
{
    public interface IDescription
    {
        string Message { get; }

        string ToString();
    }
}
