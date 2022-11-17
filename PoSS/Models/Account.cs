namespace PoSS.Models
{
    public class Account
    {
        public int Id { get; set; }

        public int TenantId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}