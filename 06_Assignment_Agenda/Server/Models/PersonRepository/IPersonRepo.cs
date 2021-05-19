using _06_Assignment_Agenda.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Assignment_Agenda.Server.Models.PersonRepository
{
    public interface IPersonRepo
    {
        Person GetPersonByID(Guid id);
        IEnumerable<Person> GetEveryPerson();
        Person AddPerson(Person person);
        Person UpdatePerson(Person person);
        void DeletePerson(Guid id);
    }
}
