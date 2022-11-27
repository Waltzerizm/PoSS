using Microsoft.AspNetCore.Mvc;
using PoSS.DTOs;
using PoSS.Models;

namespace PoSS.Controllers
{
    /// <summary>
    /// Controller for managing tax rates.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class TaxRateController : ControllerBase
    {
        /// <summary>
        /// Endpoint to get multiple tax rates.
        /// </summary>
        /// <param name="pageSize">The maximum amount of tax rates in response.</param>
        /// <param name="pageNumber">The page number of tax rates to return.</param>
        /// <returns>A list of tax rates.</returns>
        [HttpGet("{pageSize}/{pageNumber}")]
        public ActionResult<IEnumerable<TaxRateDto>> Get(int pageSize, int pageNumber)
        {
            return Ok();
        }

        /// <summary>
        /// Endpoint to get a single tax rate.
        /// </summary>
        /// <param name="id">Id of the tax rate to get</param>
        /// <returns>Tax rate with the given id.</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<TaxRate> Get(int id)
        {
            return Ok();
        }

        /// <summary>
        /// Endpoint to create a new tax rate.
        /// </summary>
        /// <param name="taxRate">Tax rate to create.</param>
        [HttpPost]
        public IActionResult Post([FromBody] TaxRateDto taxRate)
        {
            return Ok();
        }

        /// <summary>
        /// Endpoint to update a tax rate.
        /// </summary>
        /// <param name="id">Id of the tax rate to update.</param>
        /// <param name="taxRate">Tax rate to update.</param>
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TaxRateDto taxRate)
        {
            return Ok();
        }

        /// <summary>
        /// Endpoint to delete a tax rate.
        /// </summary>
        /// <param name="id">Id of the tax rate to delete.</param>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }

        // A3.	As an accountant, I want to assign tax rate to products so that ordered products are automatically taxed according to the law.
        /// <summary>
        /// Endpoint for assigning tax rate to an item.
        /// </summary>
        [HttpPost("AssignTaxRateToItem")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AssignTaxRateToItem(AssignTaxRateToItemDTO dto)
        {
            return Ok();
        }

        // A4.	As an accountant, I want to apply tax rate to categories so that all products in the selected category are assigned the same tax rate automatically.
        /// <summary>
        /// Endpoint for assigning tax rate to a category.
        /// </summary>
        [HttpPost("AssignTaxRateToCategory")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AssignTaxRateToCategory(AssignTaxRateToCategoryDTO dto)
        {
            return Ok();
        }
    }
}
