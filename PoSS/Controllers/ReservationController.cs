using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoSS.DTOs;
using PoSS.Models;

namespace PoSS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        /// <summary>
        /// Creates a reservation.
        /// </summary>
        /// <param name="reservation"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateReservation(CreateReservationDTO reservation)
        {
            return Ok(new Reservation());
        }

        /// <summary>
        /// Gets a reservation by id.
        /// </summary>
        /// <param name="reservationId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{reservationId}")]
        public IActionResult GetReservation(int reservationId)
        {
            return Ok(new Reservation());
        }

        /// <summary>
        /// Gets reservations of a customer optionally filtered by date.
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("customer/{customerId}")]
        public IActionResult GetCustomerReservations(int customerId, DateTime? from, DateTime? to)
        {
            return Ok(new List<Reservation>());
        }

        /// <summary>
        /// Cancels a reservation.
        /// </summary>
        /// <remarks>
        /// At first should check if the action is being performed by an authenticated user or a service provider.
        /// 
        /// If reservation cancelation is being requested by a service provider, a notification to a customer should be sent.
        /// </remarks>
        /// <returns></returns>
        [HttpPost]
        [Route("{reservationId}")]
        public IActionResult CancelReservation(int reservationId)
        {
            return Ok();
        }
    }
}
