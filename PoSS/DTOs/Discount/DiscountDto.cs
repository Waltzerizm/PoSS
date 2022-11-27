namespace PoSS.DTOs
{
    #pragma warning disable CS1591
    public class DiscountDto
    {
        public string Name { get; set; }

        public decimal Rate { get; set; }

        public DateTime ValidFrom { get; set; }

        public DateTime ExpiresAt { get; set; }
    }
}