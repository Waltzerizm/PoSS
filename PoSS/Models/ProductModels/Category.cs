namespace PoSS.Models.ProductModels
{
    public class Category
    {
        public int id { get; set; }
        public int tenant_id { get; set; }
        public string name { get; set; }
        public int? parent_category_id { get; set; }
    }
}
