namespace PoSS.DTOs
{
    public class CartItemDTO
    {
        /// <summary>
        /// Cart item id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Cart id
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
        /// Name of the cart item.
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// Price of the cart item.
        /// </summary>
        public decimal ItemPrice { get; set; }

        /// <summary>
        /// Quantity of the item in the cart.
        /// </summary>
        public int Quantity { get; set; }
    }
}
