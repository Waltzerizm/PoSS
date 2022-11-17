namespace PoSS.DTOs
{
    public class ServiceDto
    {
        public string Name { get; set; }
        public int DurationMins { get; set; }
        public Boolean isAvailable { get; set; }
        public int TaxRateId { get; set; }
    }
}