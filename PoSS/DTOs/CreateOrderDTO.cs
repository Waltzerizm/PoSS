namespace PoSS.DTOs
{
    public class CreateOrderDTO
    {
        public int? CustomerId { get; set; }
        public int? EmployeeId { get; set; }
        public decimal TipsAmmount { get; set; }
        public List<CreateOrderItemDTO> Items { get; set; }
    }
}
