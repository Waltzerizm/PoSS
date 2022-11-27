namespace PoSS.DTOs
{
    public class ReservationInformationDTO
    {
        /// <summary>
        /// Id of the reservation.
        /// </summary>
        public int ReservationId { get; set; }

        /// <summary>
        /// Id of the customer.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Id of the timeslot.
        /// </summary>
        public int TimeSlotId { get; set; }

        /// <summary>
        /// Name of the customer.
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Name of the assigned service provider.
        /// </summary>
        public string ServiceWorkerName { get; set; }

        /// <summary>
        /// Name of the booked service.
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// When the reservation starts.
        /// </summary>
        public DateTime Starts { get; set; }

        /// <summary>
        /// When the reservation ends.
        /// </summary>
        public DateTime Ends { get; set; }
    }
}
