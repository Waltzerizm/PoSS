using System.ComponentModel.DataAnnotations;

namespace PoSS.DTOs
{
    public class LoginDetailsDTO
    {
        /// <summary>
        /// Email of the customer.
        /// </summary>
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// Password of the customer.
        /// </summary>
        [Required]
        public string Password { get; set; }
    }
}
