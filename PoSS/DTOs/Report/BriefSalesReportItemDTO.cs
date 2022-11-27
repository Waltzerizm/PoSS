namespace PoSS.DTOs
{
    #pragma warning disable CS1591
    public class BriefSalesReportItemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Tax { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}