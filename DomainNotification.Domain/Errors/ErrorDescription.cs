using DomainNotification.Domain.Interfaces.Errors;
using DomainNotification.Domain.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainNotification.Domain.Errors
{
    public class ErrorDescription: Description
    {
        public ILevel Level { get; }
        public ErrorDescription(string message, ILevel level, params string[] args) :base(message, args)
        {
            Level = level;
        }
    }
}
