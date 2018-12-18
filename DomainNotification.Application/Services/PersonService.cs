using DomainNotification.Domain.Entities;
using DomainNotification.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using DomainNotification.Domain.Commands;

namespace DomainNotification.Application.Services
{
    public class PersonService : Service
    {
        private readonly Person _entity;

        public PersonService(Guid personId, string name, string email)
        {
            _entity = new Person(personId, name, new Email(email));
            NotificationEntity = _entity;
        }

        public void SavePerson(Guid personId, string name)
        {
            var cmd = new SavePersonCommand(_entity);
            cmd.Run();
        }
    }
}
