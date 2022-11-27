namespace PoSS.DTOs
{
    public class CreateOrderDTO
    {
        /// <summary>
        /// Id of the customer
        /// </summary>
        public int? CustomerId { get; set; }

        /// <summary>
        /// Id of the employee who completed the order in store.
        /// </summary>
        public int? EmployeeId { get; set; }

        /// <summary>
        /// Tips
        /// </summary>
        public decimal TipsAmmount { get; set; }

        /// <summary>
        /// Order items
        /// </summary>
        public List<CreateOrderItemDTO> Items { get; set; }
    }
}
