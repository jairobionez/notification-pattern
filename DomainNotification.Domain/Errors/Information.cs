using DomainNotification.Domain.Interfaces.Errors;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainNotification.Domain.Errors
{
    public class Information : ILevel
    {
        public Information(string description = "Information")
        {
            Description = description;
        }

        public string Description { get; }

        public override string ToString() => Description;        
    }
}
