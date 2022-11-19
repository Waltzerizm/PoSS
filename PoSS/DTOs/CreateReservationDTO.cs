namespace PoSS.DTOs
{
    public class CreateReservationDTO
    {
        /// <summary>
        /// Chosen timeslot.
        /// </summary>
        public int TimeSlotId { get; set; }

        /// <summary>
        /// Id of the customer that's making the reservation.
        /// </summary>
        public int CustomerId { get; set; }
    }
}
