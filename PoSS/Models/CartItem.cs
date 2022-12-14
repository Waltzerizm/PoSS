namespace PoSS.Models
{
    public class CartItem
    {
        /// <summary>
        /// Id of the cart item
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Id of the cart
        /// </summary>
        public int CartId { get; set; }

        /// <summary>
        /// If item is product, id of that produuct.
        /// </summary>
        public int? ProductId { get; set; }

        /// <summary>
        /// If item is a bundle, id of that bundle.
        /// </summary>
        public int? BundleId { get; set; }

        /// <summary>
        /// Quantity of the item.
        /// </summary>
        public int Quantity { get; set; }
    }
}
