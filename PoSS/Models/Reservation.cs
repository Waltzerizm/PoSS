namespace PoSS.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int TimeSlotId { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
