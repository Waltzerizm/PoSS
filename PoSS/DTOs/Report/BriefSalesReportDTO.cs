namespace PoSS.DTOs
{
    #pragma warning disable CS1591
    public class BriefSalesReportDTO
    {
        public BriefSalesReportItemDTO[] Items { get; set; }
        public decimal Total { get; set; }
    }
}