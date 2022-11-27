namespace PoSS.DTOs
{
    public class OrderItemDTO
    {
        /// <summary>
        /// Order item id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// If item is a product, id of that product.
        /// </summary>
        public int? ProductId { get; set; }

        /// <summary>
        /// If item is a service, id of that service.
        /// </summary>
        public int? ServiceId { get; set; }

        /// <summary>
        /// If item is a bundle, id of that bundle.
        /// </summary>
        public int? BundleId { get; set; }

        /// <summary>
        /// Name of the item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Additional notes added to the item.
        /// </summary>
        public string Notes { get; set; } = "";

        /// <summary>
        /// Quantity of the item.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Unit price of the item.
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Discount applied to the item.
        /// </summary>
        public decimal DiscountRate { get; set; }

        /// <summary>
        /// Tax rate applied to the item.
        /// </summary>
        public decimal TaxRate { get; set; }

        /// <summary>
        /// Total amount that should be paid for the item.
        /// </summary>
        public decimal Total { get; set; }
    }
}
