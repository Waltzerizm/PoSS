using PoSS.Enums;

namespace PoSS.DTOs
{
    public class OrderStatusDTO
    {
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
