using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoSS.DTOs;
using PoSS.Models;

namespace PoSS.Controllers
{
    [ApiController]
    public class ReservationController : ControllerBase
    {
        /// <summary>
        /// Creates a reservation.
        /// </summary>
        /// <param name="tenantId">Id of the tenant.</param>
        /// <param name="reservation">Details needed to create a reservation.</param>
        /// <returns>Returns information of the newly created reservation.</returns>
        /// <response code="200">Returns information of the newly created reservation.</response>
        [HttpPost]
        [Route("{tenantId}/[controller]")]
        [ProducesResponseType(typeof(ReservationInformationDTO), StatusCodes.Status200OK)]
        public IActionResult CreateReservation(int tenantId, CreateReservationDTO reservation)
        {
            return Ok(new ReservationInformationDTO());
        }

        /// <summary>
        /// Gets a reservation by id.
        /// </summary>
        /// <param name="tenantId">Id of the tenant.</param>
        /// <param name="reservationId">Id of the reservation</param>
        /// <returns>Returns information of the specified reservation.</returns>
        /// <response code="200">Returns information of the specified reservation.</response>
        /// <response code="404">When reservation doesn't exist.</response>
        [HttpGet]
        [Route("{tenantId}/[controller]/{reservationId}")]
        [ProducesResponseType(typeof(ReservationInformationDTO), StatusCodes.Status200OK)]
        public IActionResult GetReservation(int tenantId, int reservationId)
        {
            return Ok(new ReservationInformationDTO());
        }

        /// <summary>
        /// Gets alist of reservations of a customer optionally filtered by date.
        /// </summary>
        /// <param name="tenantId">Id of the tenant.</param>
        /// <param name="customerId">Id of the customer.</param>
        /// <param name="from">Get reservations starting after specified date.</param>
        /// <param name="to">Get reservations starting before specified date.</param>
        /// <returns>Returns a lsit of customer reservations.</returns>
        /// <response code="200">Returns a lsit of customer reservations.</response>
        /// <response code="200">Returns empty lsit is no reservations were found.</response>
        /// <response code="401">If user doesn't have authorization to view data.</response>
        /// <response code="403">If user is not authenticated.</response>
        [HttpGet]
        [Route("{tenantId}/Customer/{customerId}/[controller]")]
        [ProducesResponseType(typeof(List<ReservationInformationDTO>), StatusCodes.Status200OK)]
        public IActionResult GetCustomerReservations(int tenantId, int customerId, DateTime? from, DateTime? to)
        {
            return Ok(new List<ReservationInformationDTO>());
        }

        /// <summary>
        /// Cancels a reservation.
        /// </summary>
        /// <param name="tenantId">Id of the tenant.</param>
        /// <param name="reservationId">Id of the reservation.</param>
        /// <remarks>
        /// At first should check if the action is being performed by an authorized user or service provider.
        /// When the reservation gets canceled this endpoint should send a notification to the customer and the shop.
        /// </remarks>
        /// <returns>Returns that cancelation completed successfully.</returns>
        /// <response code="200">Returns that cancelation completed successfully.</response>
        [HttpPost]
        [Route("{tenantId}/[controller]/{reservationId}/Cancel")]
        public IActionResult CancelReservation(int tenantId, int reservationId)
        {
            return Ok();
        }
    }
}
