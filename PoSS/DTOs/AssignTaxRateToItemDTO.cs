namespace PoSS.DTOs
{
    public class AssignTaxRateToItemDTO
    {
        public int TaxRateId { get; set; }
        public int? ProductId { get; set; }
        public int? ServiceId { get; set; }
    }
}