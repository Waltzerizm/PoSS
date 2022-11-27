namespace PoSS.DTOs
{
    public class AddCartItemDTO
    {
        /// <summary>
        /// If item is a product, id of that product
        /// </summary>
        public int? ProductId { get; set; }

        /// <summary>
        /// If item is a bundle, id of that bundle
        /// </summary>
        public int? BundleId { get; set; }

        /// <summary>
        /// Quantity of the item
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Additional comments for te item.
        /// </summary>
        public string Comments { get; set; }
    }
}
