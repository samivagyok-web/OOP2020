using _06_Assignment_Agenda.Server.Models.ActivityRepository;
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
    public class ActivityController : Controller
    {
        private readonly IActivityRepo _activityRepo;

        public ActivityController(IActivityRepo activityRepo)
        {
            _activityRepo = activityRepo;
        }

        [HttpGet]
        public IActionResult GetEveryActivity()
        {
            return Ok(_activityRepo.GetEveryActivity());
        }

        [HttpGet("{id}")]
        public IActionResult GetActivityByID(Guid id)
        {
            return Ok(_activityRepo.GetActivityByID(id));
        }

        [HttpPost]
        public IActionResult CreateActivity([FromBody] Activity activity)
        {
            if (activity == null) return BadRequest();

            var createdActivity = _activityRepo.CreateActivity(activity);

            return Created("activity", createdActivity);
        }

        [HttpPut]
        public IActionResult UpdateActivity([FromBody] Activity activity)
        {
            if (activity == null) return BadRequest();

            var updatedActivity = _activityRepo.GetActivityByID(activity.ActivityID);

            if (updatedActivity == null) return NotFound();

            _activityRepo.UpdateActivity(activity);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteActivity(Guid id)
        {
            var activityToDelete = _activityRepo.GetActivityByID(id);

            if (activityToDelete == null) return BadRequest();

            _activityRepo.DeleteActivity(id);

            return NoContent();
        }
    }
}
