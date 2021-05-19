using _06_Assignment_Agenda.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Assignment_Agenda.Client.Services.PersonData
{
    public interface IPersonDataService
    {
        Task<IEnumerable<Person>> GetEveryPerson();
        Task<Person> GetPersonByID(Guid id);
        Task<Person> AddPerson(Person person);
        Task UpdatePerson(Person person);
        Task DeletePerson(Guid id);
    }
}
