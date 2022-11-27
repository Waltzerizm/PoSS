namespace PoSS.DTOs
{
    /// <summary>
    /// DTO for assigning a tax rate to a category.
    /// </summary>
    public class AssignTaxRateToCategoryDTO
    {
        /// <summary>
        /// Id of the category to assign the tax rate to.
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// Id of the tax rate to assign to the category.
        /// </summary>
        public int TaxRateId { get; set; }
    }
}