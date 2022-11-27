using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoSS.DTOs.ProductDTOs;
using PoSS.Models.ProductModels;
using System;
using System.Numerics;

namespace PoSS.Controllers.ProductControllers
{
    [ApiController]
    [Route("{tenantId}/[controller]")]
    public class BundleProductController : ControllerBase
    {
        /// <summary>
        /// Assign product to a bundle.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        /// <response code="400">If some class details are missing.</response>
        [HttpPost]
        public IActionResult CreateBundleProduct(BundleProduct product)
        {
            return Ok();
        }

        /// <summary>
        /// Get bundle's assigned product by bundle Id and product Id.
        /// </summary>
        /// <param name="bundleId"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
        /// <response code="404">If bundle with such id does not exist.</response>
        /// <response code="404">If product with such id does not exist.</response>
        /// <response code="404">If product with such id is not assigned to bundle with such id.</response>
        [HttpGet]
        [Route("{bundleId}/{productId}")]
        [ProducesResponseType(typeof(BundleProduct), StatusCodes.Status200OK)]
        public IActionResult GetBundleProduct(int bundleId, int productId)
        {
            return Ok(new BundleProduct());
        }

        /// <summary>
        /// Get list of bundle's all assigned products by bundle Id.
        /// </summary>
        /// <param name="bundleId"></param>
        /// <returns></returns>
        /// <response code="404">If bundle with such id does not exist.</response>
        [HttpGet]
        [Route("{bundleId}")]
        [ProducesResponseType(typeof(List<BundleProduct>), StatusCodes.Status200OK)]
        public IActionResult GetBundleProducts(int bundleId)
        {
            return Ok(new List<BundleProduct>());
        }

        /// <summary>
        /// Update bundle's assigned product by bundle Id and product Id.
        /// </summary>
        /// <param name="bundleId"></param>
        /// <param name="productId"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        /// <response code="404">If bundle with such id does not exist.</response>
        /// <response code="404">If product with such id does not exist.</response>
        /// <response code="404">If product with such id is not assigned to bundle with such id.</response>
        /// <response code="400">If some class details are missing.</response>
        [HttpPut]
        [Route("{bundleId}/{productId}")]
        public IActionResult UpdateBundleProduct(int bundleId, int productId, BundleProduct product)
        {
            return Ok();
        }

        /// <summary>
        /// Delete bundle's assigned product by bundle Id and product Id.
        /// </summary>
        /// <param name="bundleId"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
        /// <response code="404">If bundle with such id does not exist.</response>
        /// <response code="404">If product with such id does not exist.</response>
        /// <response code="404">If product with such id is not assigned to bundle with such id.</response>
        [HttpDelete]
        [Route("{bundleId}/{productId}")]
        public IActionResult DeleteBundleProduct(int bundleId, int productId)
        {
            return Ok();
        }
    }
}
