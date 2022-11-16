namespace PoSS.Models
{
    public class Service
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public string Name { get; set; }
        public int DurationMins { get; set; }
        public Boolean isAvailable { get; set; }
        public int TaxRateId { get; set; }
    }
}