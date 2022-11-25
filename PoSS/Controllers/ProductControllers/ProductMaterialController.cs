using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoSS.Models.ProductModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;

namespace PoSS.Controllers.ProductControllers
{
    [ApiController]
    [Route("{tenantId}/[controller]")]
    public class ProductMaterialController : ControllerBase
    {
        //SHOULD
        /// <summary>
        /// Assign material to a product.
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        /// <response code="400">If some class details are missing.</response>
        [HttpPost]
        public IActionResult AddProductMaterial(ProductMaterial material)
        {
            return Ok();
        }

        /// <summary>
        /// Get product's assigned material by product Id and material Id.
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="materialId"></param>
        /// <returns></returns>
        /// <response code="400">If product with such id does not exist.</response>
        /// <response code="400">If material with such id does not exist.</response>
        /// <response code="400">If material with such id is not assigned to product with such id.</response>
        [HttpGet]
        [Route("{productId}/{materialId}")]
        public IActionResult GetProductMaterial(int productId, int materialId)
        {
            return Ok(new ProductMaterial());
        }

        /// <summary>
        /// Get list of product's all assigned materials by product Id.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        /// <response code="400">If product with such id does not exist.</response>
        [HttpGet]
        [Route("{productId}")]
        public IActionResult GetProductMaterials(int productId)
        {
            return Ok(new List<ProductMaterial>());
        }

        /// <summary>
        /// Update product's assigned material by product Id and material Id.
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="materialId"></param>
        /// <param name="material"></param>
        /// <returns></returns>
        /// <response code="400">If product with such id does not exist.</response>
        /// <response code="400">If material with such id does not exist.</response>
        /// <response code="400">If material with such id is not assigned to product with such id.</response>
        /// <response code="400">If some class details are missing.</response>
        [HttpPut]
        [Route("{productId}/{materialId}")]
        public IActionResult UpdateBundleProduct(int productId, int materialId, ProductMaterial material)
        {
            return Ok();
        }

        /// <summary>
        /// Delete product's assigned material by product Id and material Id.
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="materialId"></param>
        /// <returns></returns>
        /// <response code="400">If product with such id does not exist.</response>
        /// <response code="400">If material with such id does not exist.</response>
        /// <response code="400">If material with such id is not assigned to product with such id.</response>
        [HttpDelete]
        [Route("{productId}/{materialId}")]
        public IActionResult DeleteBundleProduct(int productId, int materialId)
        {
            return Ok();
        }
    }
}
