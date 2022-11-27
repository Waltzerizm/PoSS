using Microsoft.AspNetCore.Mvc;
using PoSS.DTOs;
using PoSS.Models;

namespace PoSS.Controllers
{
    /// <summary>
    /// Controller for managing discounts.
    /// </summary>
    [ApiController]
    [Route("{tenantId}/[controller]")]
    public class DiscountController : ControllerBase
    {
        /// <summary>
        /// Endpoint to get multiple discounts.
        /// </summary>
        /// <param name="pageSize">The maximum amount of discounts in response.</param>
        /// <param name="pageNumber">The page number of discounts to return.</param>
        /// <param name="tenantId">Id of the store.</param>
        /// <returns>A list of discounts.</returns>
        [HttpGet("{pageSize}/{pageNumber}")]
        public ActionResult<IEnumerable<Discount>> Get(int tenantId, int pageSize, int pageNumber)
        {
            return Ok();
        }

        /// <summary>
        /// Endpoint to get a single discount.
        /// </summary>
        /// <param name="id">Id of the discount to get</param>
        /// <param name="tenantId">Id of the store.</param>
        /// <returns>Discount with the given id.</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<DiscountDto> Get(int tenantId, int id)
        {
            return Ok();
        }

        /// <summary>
        /// Endpoint to create a new discount.
        /// </summary>
        /// <param name="discount">Discount to create.</param>
        [HttpPost]
        public IActionResult Post([FromBody] DiscountDto discount)
        {
            return Ok();
        }

        /// <summary>
        /// Endpoint to update a discount.
        /// </summary>
        /// <param name="id">Id of the discount to update.</param>
        /// <param name="discount">Discount to update.</param>
        /// <param name="tenantId">Id of the store.</param>
        [HttpPut("{id}")]
        public IActionResult Put(int tenantId, int id, [FromBody] DiscountDto discount)
        {
            return Ok();
        }

        // BO11.	As a business owner, I want to assign a discount to a product or a service so that the discount is automatically applied when the product or service is purchased.
        /// <summary>
        /// Endpoint to assign a discount to a product or service.
        /// </summary>
        /// <param name="tenantId">Id of the store.</param>
        /// <param name="dto"></param>
        [HttpPost("AssignDiscountToItem")]
        public IActionResult AssignDiscountToItem(int tenantId, AssignDiscountToItemDTO dto)
        {
            return Ok();
        }

        // BO12.	As a business owner, I want to assign a discount to a brand, so that the discount is automatically applied to any product made by the selected brand.
        /// <summary>
        /// Endpoint to assign a discount to a brand.
        /// </summary>
        /// <param name="tenantId">Id of the store.</param>
        /// <param name="dto"></param>
        [HttpPost("AssignDiscountToBrand")]
        public IActionResult AssignDiscountToBrand(int tenantId, AssignDiscountToBrandDTO dto)
        {
            return Ok();
        }

        // BO13.	As a business owner, I want to assign a discount to a category, so that the discount is automatically applied to any product from the selected category.
        /// <summary>
        /// Endpoint to assign a discount to a category.
        /// </summary>
        /// <param name="tenantId">Id of the store.</param>
        /// <param name="dto"></param>
        [HttpPost("AssignDiscountToCategory")]
        public IActionResult AssignDiscountToCategory(int tenantId, AssignDiscountToCategoryDTO dto)
        {
            return Ok();
        }
    }
}