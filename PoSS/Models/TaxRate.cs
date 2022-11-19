namespace PoSS.Models
{
    public class TaxRate
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
    }
}