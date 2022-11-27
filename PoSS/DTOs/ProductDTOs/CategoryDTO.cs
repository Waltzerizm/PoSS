namespace PoSS.Models.ProductModels
{
    public class CategoryDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? parent_category_id { get; set; }
    }
}
