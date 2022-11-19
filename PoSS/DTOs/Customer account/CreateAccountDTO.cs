using System.ComponentModel.DataAnnotations;

namespace PoSS.DTOs
{
    public class CreateAccountDTO
    {
        /// <summary>
        /// Name of the customer.
        /// </summary>
        [Required]
        public string Name { get; set; }

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
