using PoSS.Models.ProductModels;
namespace PoSS.DTOs.ProductDTOs
{
    public class BundleDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public List<BundleProduct> products { get; set; }
    }
}
