namespace PoSS.Models {
    public class Discount 
    {
        public int Id { get; set; }

        public int TenantId { get; set; }

        public string Name { get; set; }

        public decimal Rate { get; set; }

        public DateTime ValidFrom { get; set; }

        public DateTime ExpiresAt { get; set; }
    }
}