namespace PoSS.Models
{
    public class TimeSlot
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int LocationId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
