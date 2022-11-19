using PoSS.Models;

namespace PoSS.DTOs
{
    public class CartDTO
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastAccessed { get; set; }
        public List<CartItem> Items { get; set; }
    }
}
