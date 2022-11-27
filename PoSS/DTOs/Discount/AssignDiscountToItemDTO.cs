namespace PoSS.DTOs
{
    #pragma warning disable CS1591
    public class AssignDiscountToItemDTO
    {
        public int DiscountId { get; set; }
        public int? ProductId { get; set; }
        public int? ServiceId { get; set; }
    }
}