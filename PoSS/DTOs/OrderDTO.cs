using PoSS.Models;

namespace PoSS.DTOs
{
    public class OrderDTO
    {
        /// <summary>
        /// Order id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Id of the customer.
        /// </summary>
        public int? CustomerId { get; set; }

        /// <summary>
        /// Id of the employee who completed the order.
        /// </summary>
        public int? EmployeeId { get; set; }

        /// <summary>
        /// Tips
        /// </summary>
        public decimal TipsAmmount { get; set; }

        /// <summary>
        /// Ordered items.
        /// </summary>
        public List<OrderItemDTO> Items { get; set; }

        /// <summary>
        /// Amount to be paid for the order.
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        /// Oder status.
        /// </summary>
        public OrderStatus Status { get; set; }

        /// <summary>
        /// Payment linked to the order.
        /// </summary>
        public PaymentDTO? Payment { get; set; }
    }
}
