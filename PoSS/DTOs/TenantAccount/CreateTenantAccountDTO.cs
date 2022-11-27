using System.ComponentModel.DataAnnotations;

namespace PoSS.DTOs
{
    #pragma warning disable CS1591
    public class CreateTenantAccountDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
    }
}
