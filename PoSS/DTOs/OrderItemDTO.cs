namespace PoSS.DTOs
{
    public class OrderItemDTO
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? ServiceId { get; set; }
        public int? BundleId { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; } = "";
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal TaxRate { get; set; }
        public decimal Total { get; set; }
    }
}
