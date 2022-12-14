using Microsoft.AspNetCore.Mvc;
using PoSS.Models;
using PoSS.DTOs;
using PoSS.DTOs.ProductDTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PoSS.Controllers
{
    [Route("{tenantId}/[controller]")]
    [ApiController]
    public class TimeSlotController : ControllerBase
    {
        /// <summary>
        /// Gets time slot by id
        /// </summary>
        /// <param name="timeSlotId"></param>
        /// <returns>Returns the details of the time slot</returns>
        /// <response code="200">Returns time slot details</response>
        /// <response code="400">If time slot ID is less or equal to 0</response>
        /// <response code="404">If no time slot ID matched the search</response>
        [HttpGet]
        [Route("{timeSlotId}")]
        [ProducesResponseType(typeof(TimeSlotDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<TimeSlotDTO> GetTimeSlot(int tenantId, int timeSlotId)
        {
            if (timeSlotId <= 0)
            {
                return BadRequest();
            }

            return Ok(new TimeSlotDTO()); // return random generated item by id
        }

        /// <summary>
        /// Get a list of time slots
        /// </summary>
        /// <param name="serviceId">Returns a list of time slots that match the service ID</param>
        /// <param name="locationId">Returns a list of time slots that match the location ID</param>
        /// <param name="employeeId">Returns a list of time slots that match the employee ID</param>
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <param name="pageSize">Parameter to define how many records are in a page.</param>
        /// <param name="pageNumber">Parameter to specify which page of records to return.</param>
        /// <returns></returns>
        /// <response code="400">If time slot service ID is less or equal to 0</response>
        /// <response code="404">If no time slot service ID matched the search</response>
        [HttpGet("{pageSize}/{pageNumber}")]
        [ProducesResponseType(typeof(List<TimeSlotDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<TimeSlotDTO>> GetTimeSlots([FromQuery] int[]? serviceId, [FromQuery] int[]? locationId, [FromQuery] int[]? employeeId, 
                                                            [FromQuery] string? FromDate, [FromQuery] string? ToDate,
                                                            int pageSize, int pageNumber)
        {
            return Ok(new List<TimeSlotDTO>()); 
        }

        // As a service provider, I want to have an ability to book a time slot on behalf of a customer so that
        // I can reserve time for a customer who calls by phone or visits a store.
        /// <summary>
        /// Creates a time slot
        /// </summary>
        /// <param name="newTimeSlot"></param>
        /// <returns></returns>
        /// <response code="201">If time slot has been succesfully created</response>
        /// <response code="400">If provided time slot details do not pass the validation</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult CreateTimeSlot(int tenantId, TimeSlotDTO newTimeSlot)
        {
            return Ok();
        }

        /// <summary>
        /// Updates time slot
        /// </summary>
        /// <param name="timeSlotId"></param>
        /// <param name="newTimeSlot"></param>
        /// <returns></returns>
        /// <response code="200">If time slot details have been succesfully updated</response>
        /// <response code="400">If provided time slot details do not pass the validation</response>
        /// <response code="404">If no time slot ID matched the search</response>
        [HttpPut]
        [Route("{timeSlotId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult UpdateTimeSlot(int tenantId, int timeSlotId, TimeSlotDTO newTimeSlot)
        {
            if (timeSlotId <= 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        /// <summary>
        /// Deletes time slot
        /// </summary>
        /// <param name="timeSlotId"></param>
        /// <returns></returns>
        /// <response code="200">If time slot have been succesfully deleted</response>
        /// <response code="400">If time slot ID is less or equal to 0</response>
        /// <response code="404">If no time slot ID matched the search</response>
        [HttpDelete]
        [Route("{timeSlotId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult DeleteTimeSlot(int tenantId, int timeSlotId)
        {
            if (timeSlotId <= 0)
            {
                return BadRequest();
            }

            return Ok();
        }

    }
}
