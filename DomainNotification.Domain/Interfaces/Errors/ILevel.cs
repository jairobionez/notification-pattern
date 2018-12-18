using System;
using System.Collections.Generic;
using System.Text;

namespace DomainNotification.Domain.Interfaces.Errors
{
    public interface ILevel
    {
        string Description { get; }
        string ToString();
    }
}
