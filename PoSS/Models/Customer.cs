namespace PoSS.Models
{
    public class Customer
    {
        /// <summary>
        /// Id of the customer.
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Id of the bussiness.
        /// </summary>
        int TenantId { get; set; }

        /// <summary>
        /// Name of the customer.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Email of the customer.
        /// </summary>
        string Email { get; set; }

        /// <summary>
        /// Password of the customer.
        /// </summary>
        string Password { get; set; }
    }
}
