namespace PoSS.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public int? CustomerId { get; set; }
        public int? EmployeeId { get; set; }
        public decimal TipAmmount { get; set; }
        public decimal Total { get; set; }
    }
}
