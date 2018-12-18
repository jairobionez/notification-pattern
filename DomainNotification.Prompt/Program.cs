using DomainNotification.Application.Services;
using DomainNotification.Prompt.DTO;
using System;

namespace DomainNotification.Prompt
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Type your name");
            var name = Console.ReadLine();
            Console.WriteLine("Type your E-mail");
            var email = Console.ReadLine();

            var personDTO = new PersonDTO(Guid.NewGuid(), name, email);
            var personService = new PersonService(personDTO.PersonId, personDTO.Name, personDTO.Email);

            Submit(personService, personDTO);
            Console.ReadKey();
        }

        public static void Submit(PersonService personService, PersonDTO personDto)
        {
            personService.SavePerson(personDto.PersonId,
                                     personDto.Name);

            if (personService.HasNotifications)
                ShowNotifications(personService);
        }

        private static void ShowNotifications(Service personService)
        {
            if (!personService.HasNotifications) return;

            if (personService.HasErrors)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nErrors\n");

                foreach (var error in personService.Errors())
                {
                    Console.WriteLine(error.ToString());
                }
            }

            if (personService.HasWarnings)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nWarnings\n");

                foreach (var error in personService.Warnings())
                {
                    Console.WriteLine(error.ToString());
                }
            }

            if (personService.HasInformations)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nInformations\n");

                foreach (var error in personService.Informations())
                {
                    Console.WriteLine(error.ToString());
                }
            }
        }
    }
}
