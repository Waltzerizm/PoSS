using Microsoft.AspNetCore.Mvc;
using PoSS.Models;
using GenFu;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PoSS.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class TimeSlotController : ControllerBase
    {
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public ActionResult<TimeSlot> GetAllTimeSlots([FromQuery] int objectCount)
        {
            if (objectCount < 0)
            {
                return BadRequest();
            }

            A.Configure<TimeSlot>()
                .Fill(e => e.Id).WithinRange(1, objectCount);

            return Ok(A.ListOf<TimeSlot>(objectCount)); // return random generated list of items
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public ActionResult<TimeSlot> GetTimeSlotById([FromQuery] int timeSlotId)
        {
            if (timeSlotId <= 0)
            {
                return BadRequest();
            }

            A.Configure<TimeSlot>()
                .Fill(e => e.Id, timeSlotId);
            return Ok(A.New<TimeSlot>()); // return random generated item by id
        }

        // As a service provider, I want to view all time slots that are assigned to me so that I can plan my agenda.  
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public ActionResult<TimeSlot> GetTimeSlotsByEmployeeId([FromQuery] int timeSlotId)
        {
            if (timeSlotId <= 0)
            {
                return BadRequest();
            }

            A.Configure<TimeSlot>()
                .Fill(e => e.EmployeeId, timeSlotId);
            return Ok(A.ListOf<TimeSlot>(10)); // return random generated item by id
        }

        // As a service provider, I want to have an ability to book a time slot on behalf of a customer so that
        // I can reserve time for a customer who calls by phone or visits a store. 
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public ActionResult CreateTimeSlot([FromBody] TimeSlot newTimeSlot)
        {
            return Ok();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut]
        public ActionResult UpdateTimeSlot([FromQuery] int timeSlotId, [FromBody] TimeSlot newTimeSlot)
        {
            if (timeSlotId <= 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete]
        public ActionResult DeleteTimeSlot([FromQuery] int timeSlotId)
        {
            if (timeSlotId <= 0)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
