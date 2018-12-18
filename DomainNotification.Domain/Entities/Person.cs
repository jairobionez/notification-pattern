using DomainNotification.Domain.Errors;
using DomainNotification.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainNotification.Domain.Entities
{
    public class Person : Entity
    {
        public Person(Guid personId, string name, Email email)
        {
            PersonId = personId;
            Name = name;
            Email = email;
            Validate();
        }

        public Guid PersonId { get; }
        public string Name { get; }
        public Email Email { get; }

        public sealed override void Validate()
        {
            IsInvalidGuid(PersonId, InvalidId);
            IsInvalidName(Name, InvalidName);
            IsInvalidEmail(Email, InvalidPersonEmail);
        }

        protected void IsInvalidEmail(Email s, ErrorDescription error)
        {
            Fail(Email.Notification.HasErrors, error);
        }


        public static ErrorDescription InvalidPersonEmail = new ErrorDescription("Invalid E-mail, see object notifications for more details.", new Critical());

    }
}
