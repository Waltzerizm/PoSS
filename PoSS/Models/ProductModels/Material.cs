namespace PoSS.Models.ProductModels
{
    public class Material
    {
        public int id { get; set; }
        public int tenant_id { get; set; }
        public string name { get; set; }
        public string unit { get; set; }
        public int available_quantity { get; set; }
    }
}
