using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoSS.Models.ProductModels;
using System;
using System.Numerics;

namespace PoSS.Controllers.ProductControllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BundleProductController : ControllerBase
    {
        [HttpPost(Name = "AddBundleProduct")]
        public IActionResult AddBundleProduct([FromBody] BundleProduct value)
        {
            return Ok();
        }

        [HttpGet(Name = "GetBundleProduct")]
        public IActionResult GetBundleProduct(int bundle_id, int product_id)
        {
            return Ok();
        }

        [HttpGet(Name = "GetBundleProducts/{id}")]
        public IActionResult GetBundleProducts(int bundle_id)
        {
            return Ok();
        }

        [HttpPut(Name = "EditBundleProduct")]
        public IActionResult EditBundleProduct(int bundle_id, int product_id, [FromBody] BundleProduct value)
        {
            return Ok();
        }

        [HttpDelete(Name = "DeleteBundleProduct")]
        public IActionResult DeleteBundleProduct(int bundle_id, int product_id)
        {
            return Ok();
        }
    }
}
