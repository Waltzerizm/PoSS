namespace PoSS.DTOs.ProductDTOs
{
    public class ProductStatusDTO
    {
        public int product_id { get; set; }
        public int available_quantity { get; set; }
        public bool is_disabled { get; set; }
    }
}
