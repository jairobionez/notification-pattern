using System;
using System.Collections.Generic;
using System.Text;

namespace DomainNotification.Prompt.DTO
{
    public class PersonDTO
    {
        public PersonDTO(Guid personId, string name, string email)
        {
            PersonId = personId;
            Name = name;
            Email = email;
        }

        public Guid PersonId { get; }
        public string Name { get; }
        public string Email { get; }
    }
}
