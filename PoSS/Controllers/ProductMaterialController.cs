using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoSS.Models.ProductModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;

namespace PoSS.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductMaterialController : ControllerBase
    {
        //SHOULD
        [HttpPost(Name = "AddProductMaterial")]
        public IActionResult AddProductMaterial([FromBody] ProductMaterial value)
        {
            return Ok();
        }

        [HttpGet(Name = "GetProductMaterial")]
        public IActionResult GetProductMaterial(int product_id, int material_id )
        {
            return Ok();
        }

        [HttpGet(Name = "GetProductMaterials/{id}")]
        public IActionResult GetProductMaterials(int product_id)
        {
            return Ok();
        }

        [HttpPut(Name = "EditProductMaterial")]
        public IActionResult EditBundleProduct(int product_id, int material_id, [FromBody] ProductMaterial value)
        {
            return Ok();
        }

        [HttpDelete(Name = "DeleteProductMaterial")]
        public IActionResult DeleteBundleProduct(int product_id, int material_id)
        {
            return Ok();
        }
    }
}
