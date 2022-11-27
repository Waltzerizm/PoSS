using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoSS.Models.ProductModels;
using System.Numerics;
using PoSS.DTOs.ProductDTOs;

namespace PoSS.Controllers.ProductControllers
{
    [ApiController]
    [Route("{tenantId}/[controller]")]
    public class ProductController : ControllerBase
    {
        //As an inventory manager, I want to create a product so that finished products, sold by the business, are available in the catalog and tracked by the system.
        /// <summary>
        /// Create product.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        /// <response code="400">If some product details are missing.</response>
        [HttpPost]
        public IActionResult CreateProduct(ProductDTO product)
        {
            return Ok();
        }

        //As an inventory manager, I want to view product details so that I can review how the product is described to the clients.
        /// <summary>
        /// Get product by Id.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        /// <response code="404">If product with such id does not exist.</response>
        [HttpGet]
        [Route("{productId}")]
        [ProducesResponseType(typeof(ProductDTO), StatusCodes.Status200OK)]
        public IActionResult GetProduct(int productId)
        {
            return Ok(new ProductDTO());
        }

        /// <summary>
        /// Get a list of products.
        /// </summary>
        /// <param name="pageSize">Parameter to define how many records are in a page.</param>
        /// <param name="page">Parameter to specify which page of records to return.</param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<ProductDTO>), StatusCodes.Status200OK)]
        public IActionResult GetProducts([FromQuery] int? pageSize, [FromQuery] int? page)
        {
            return Ok(new List<ProductDTO>());
        }

        //As an inventory manager, I want to update product details.
        /// <summary>
        /// Update product by id.
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        /// <response code="404">If product with such id does not exist.</response>
        /// <response code="400">If some product details are missing.</response>
        [HttpPut]
        [Route("{productId}")]
        public IActionResult UpdateProduct(int productId, ProductDTO product)
        { 
            return Ok();
        }

        /// <summary>
        /// Delete product by id.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        /// <response code="404">If product with such id does not exist.</response>
        [HttpDelete]
        [Route("{productId}")]
        public IActionResult DeleteProduct(int productId)
        {
            return Ok();
        }
    }
}
