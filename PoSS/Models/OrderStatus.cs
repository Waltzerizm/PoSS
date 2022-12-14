using PoSS.Enums;

namespace PoSS.Models
{
    public class OrderStatus
    {
        /// <summary>
        /// Order status ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Order ID
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// The order's status
        /// </summary>
        public OrderStatusTypes Status { get; set; }
    }
}
