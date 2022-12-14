using Poss.Models;

namespace PoSS.Models
{
    public class Location
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
    }
}