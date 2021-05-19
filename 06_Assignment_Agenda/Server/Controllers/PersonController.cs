using _06_Assignment_Agenda.Server.Models.PersonRepository;
using _06_Assignment_Agenda.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Assignment_Agenda.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonRepo _personRepo;

        public PersonController(IPersonRepo personRepo)
        {
            _personRepo = personRepo;
        }

        [HttpGet]
        public IActionResult GetEveryPerson()
        {
            return Ok(_personRepo.GetEveryPerson());
        }

        [HttpGet("{id}")]
        public IActionResult GetPersonByID(Guid id)
        {
            return Ok(_personRepo.GetPersonByID(id));
        }

        [HttpPost]
        public IActionResult CreatePerson([FromBody] Person person)
        {
            if (person == null) return BadRequest();

            var createdPerson = _personRepo.AddPerson(person);

            return Created("person", createdPerson);
        }

        [HttpPut]
        public IActionResult UpdatePerson([FromBody] Person person)
        {
            if (person == null) return BadRequest();

            var personToUpdate = _personRepo.GetPersonByID(person.PersonID);

            if (personToUpdate == null) return NotFound();

            _personRepo.UpdatePerson(person);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePerson(Guid id)
        {
            var personToDelete = _personRepo.GetPersonByID(id);

            if (personToDelete == null) return BadRequest();

            _personRepo.DeletePerson(id);

            return NoContent();
        }

    }
}
