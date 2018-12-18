using DomainNotification.Domain.Interfaces.Errors;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainNotification.Domain.Errors
{
    public class Critical : ILevel
    {
        public Critical(string description = "Critical")
        {
            Description = description;
        }

        public string Description { get; }

        public override string ToString() => Description;
    }
}
