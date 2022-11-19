namespace PoSS.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int? ProductId { get; set; }
        public int? BundleId { get; set; }
        public int Quantity { get; set; }
    }
}
