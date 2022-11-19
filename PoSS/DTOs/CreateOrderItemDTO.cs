namespace PoSS.DTOs
{
    public class CreateOrderItemDTO
    {
        public int? ProductId { get; set; }
        public int? ServiceId { get; set; }
        public int? BundleId { get; set; }
        public string Notes { get; set; } = "";
        public int Quantity { get; set; }
    }
}
