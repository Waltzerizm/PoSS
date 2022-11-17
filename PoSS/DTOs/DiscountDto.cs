namespace PoSS.DTOs
{
    public class DiscountDto
    {
        public string Name { get; set; }

        public decimal Rate { get; set; }

        public DateTime ValidFrom { get; set; }

        public DateTime ExpiresAt { get; set; }
    }
}