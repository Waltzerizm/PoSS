namespace PoSS.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastAccessed { get; set; }
    }
}
