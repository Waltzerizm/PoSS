using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoSS.Models.ProductModels;
using System.Numerics;
using PoSS.DTOs.ProductDTOs;

namespace PoSS.Controllers.ProductControllers
{
    [ApiController]
    [Route("{tenantId}/[controller]")]
    public class ProductStatusController : ControllerBase
    {
        /// <summary>
        /// Create product status.
        /// </summary>
        /// <param name="productStatus"></param>
        /// <returns></returns>
        /// <response code="400">If some product status details are missing.</response>
        [HttpPost]
        public IActionResult CreateProductStatus(ProductStatusDTO productStatus)
        {
            return Ok();
        }

        /// <summary>
        /// Get product status by Id.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        /// <response code="400">If product with such id does not exist.</response>
        [HttpGet]
        [Route("{productId}")]
        public IActionResult GetProductStatus(int productId)
        {
            return Ok(new ProductStatusDTO());
        }

        //As an inventory manager, I want to retire a product so that it is no longer visible to the customers while preserving historical order data.
        /// <summary>
        /// Update product status by id (Enable/Disable, update quantity).
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="productStatus"></param>
        /// <returns></returns>
        /// <response code="400">If product with such id does not exist.</response>
        /// <response code="400">If some product status details are missing.</response>
        [HttpPut]
        [Route("{productId}")]
        public IActionResult UpdateProductStatus(int productId, ProductStatusDTO productStatus)
        { 
            return Ok();
        }

        /// <summary>
        /// Delete product status by id.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        /// <response code="400">If product with such id does not exist.</response>
        [HttpDelete]
        [Route("{productId}")]
        public IActionResult DeleteProductStatus(int productId)
        {
            return Ok();
        }


    }
}
