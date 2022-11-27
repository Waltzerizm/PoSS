﻿namespace PoSS.Models
{
    public class TimeSlot
    {
        /// <summary>
        /// ID of the time slot
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// ID of the service is provided during the time slot
        /// </summary>
        public int ServiceId { get; set; }
        /// <summary>
        /// ID of the location where the service is provided
        /// </summary>
        public int LocationId { get; set; }
        /// <summary>
        /// ID of the employer which provides the service
        /// </summary>
        public int EmployeeId { get; set; }
        /// <summary>
        /// Time slot start time
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// Time slot end time
        /// </summary>
        public DateTime EndTime { get; set; }
    }
}
