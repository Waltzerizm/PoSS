using PoSS.Enums;

namespace PoSS.DTOs
{
    public class PaymentDTO
    {
        /// <summary>
        /// Order id
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Payment type
        /// </summary>
        public PaymentType PaymentType { get; set; }

        /// <summary>
        /// Ammount paid
        /// </summary>
        public decimal Ammount { get; set; }

        /// <summary>
        /// If paid by cash, ammount of change given
        /// </summary>
        public decimal? Change { get; set; }
    }
}
