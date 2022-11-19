using PoSS.Models;

namespace PoSS.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? EmployeeId { get; set; }
        public decimal TipsAmmount { get; set; }
        public List<OrderItemDTO> Items { get; set; }
        public decimal Total { get; set; }
        public OrderStatus Status { get; set; }
        public PaymentDTO? Payment { get; set; }
    }
}
