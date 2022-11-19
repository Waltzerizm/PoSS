using PoSS.Enums;

namespace PoSS.Models
{
    public class OrderStatus
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public OrderStatusTypes Status { get; set; }
    }
}
