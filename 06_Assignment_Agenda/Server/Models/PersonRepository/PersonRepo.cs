using _06_Assignment_Agenda.Server.Data;
using _06_Assignment_Agenda.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Assignment_Agenda.Server.Models.PersonRepository
{
    public class PersonRepo : IPersonRepo
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public PersonRepo(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public Person AddPerson(Person person)
        {
            _applicationDbContext.People.Add(person);
            _applicationDbContext.SaveChanges();

            return person;
        }

        public void DeletePerson(Guid id)
        {
            var personToDelete = _applicationDbContext.People.FirstOrDefault(p => p.PersonID == id);

            if (personToDelete == null) return;

            _applicationDbContext.People.Remove(personToDelete);
            _applicationDbContext.SaveChanges();
        }

        public IEnumerable<Person> GetEveryPerson()
        {
            return _applicationDbContext.People;
        }

        public Person GetPersonByID(Guid id)
        {
            return _applicationDbContext.People.FirstOrDefault(p => p.PersonID == id);
        }

        public Person UpdatePerson(Person person)
        {
            var personToUpdate = _applicationDbContext.People.FirstOrDefault(p => p.PersonID == person.PersonID);

            if (personToUpdate == null) return null;

            personToUpdate.PersonID = person.PersonID;
            personToUpdate.FirstName = person.FirstName;
            personToUpdate.LastName = person.LastName;
            personToUpdate.CalendarID = person.CalendarID;
            personToUpdate.Birthday = person.Birthday;
            personToUpdate.Email = person.Email;

            _applicationDbContext.SaveChanges();

            return personToUpdate;
        }
    }
}
