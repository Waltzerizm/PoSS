using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoSS.Models.ProductModels;
using System;
using System.Numerics;

namespace PoSS.Controllers.ProductControllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BundleController : ControllerBase
    {
        //As an inventory manager, I want to manage bundles so that common sets of products can be purchased at a special price.
        [HttpPost(Name = "CreateBundle")]
        public IActionResult CreateBundle([FromBody] Bundle value)
        {
            return Ok();
        }

        [HttpGet(Name = "GetBundle/{id}")]
        public IActionResult GetBundle(int id)
        {
            return Ok();
        }

        [HttpGet(Name = "GetBundles")]
        public IActionResult GetBundles()
        {
            return Ok();
        }

        [HttpPut(Name = "UpdateBundle/{id}")]
        public IActionResult UpdateBundle(int id, [FromBody] Bundle value)
        {
            if (id != value.id)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpDelete(Name = "DeleteBundle/{id}")]
        public IActionResult DeleteBundle(int id)
        {
            return Ok();
        }
    }
}
