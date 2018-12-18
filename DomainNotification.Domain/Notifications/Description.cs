using DomainNotification.Domain.Interfaces.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainNotification.Domain.Notifications
{
    public abstract class Description: IDescription
    {
        public string Message { get; }

        protected Description(string message, params string[] args)
        {
            Message = message;

            for (var i = 0; i < args.Length; i++)
            {
                Message = Message.Replace("{" + i + "}", args[i]);
            }
        }

        public override string ToString() => Message;
    }
}
