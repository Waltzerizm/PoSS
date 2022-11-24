using PoSS.Models.ProductModels;
namespace PoSS.DTOs.ProductDTOs
{
    public class ProductDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string unit { get; set; }
        public int price { get; set; }
        public int brand_id { get; set; }
        public int tax_rate_id { get; set; }
        public int available_quantity { get; set; }
        public bool is_disabled { get; set; }
        public List<ProductMaterial> materials { get; set; }
    }
}
