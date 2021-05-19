using _06_Assignment_Agenda.Server.Models.CalendarRepository;
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
    public class CalendarController : Controller
    {
        private readonly ICalendarRepo _calendarRepo;

        public CalendarController(ICalendarRepo calendarRepo)
        {
            _calendarRepo = calendarRepo;
        }

        [HttpGet]
        public IActionResult GetEveryCalendar()
        {
            return Ok(_calendarRepo.GetEveryCalendar());
        }

        [HttpGet("{id}")]
        public IActionResult GetCalendarByID(Guid id)
        {
            return Ok(_calendarRepo.GetCalendarByID(id));
        }

        [HttpPost]
        public IActionResult CreateCalendar([FromBody] Calendar calendar)
        {
            if (calendar == null) return BadRequest();

            var createdCalendar = _calendarRepo.CreateCalendar(calendar);

            return Created("calendar", createdCalendar);
        }

        [HttpPut]
        public IActionResult UpdateCalendar(Calendar calendar)
        {
            if (calendar == null) return BadRequest();

            var updatedCalendar = _calendarRepo.GetCalendarByID(calendar.CalendarID);

            if (updatedCalendar == null) return NotFound();

            _calendarRepo.UpdateCalendar(calendar);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCalendar(Guid id)
        {
            var calendarToDelete = _calendarRepo.GetCalendarByID(id);

            if (calendarToDelete == null) return BadRequest();

            _calendarRepo.DeleteCalendar(id);

            return NoContent();
        }

    }
}
