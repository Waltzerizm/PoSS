namespace PoSS.DTOs
{
    #pragma warning disable CS1591
    public class DetailedSalesReportDTO
    {
        public OrderItemDTO[] Items { get; set; }
        public decimal Total { get; set; }
    }
}