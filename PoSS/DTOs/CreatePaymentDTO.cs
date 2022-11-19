using PoSS.Enums;

namespace PoSS.DTOs
{
    public class PaymentDTO
    {
        public int OrderId { get; set; }
        public PaymentType PaymentType { get; set; }
        public decimal Ammount { get; set; }
        public decimal Change { get; set; }
    }
}
