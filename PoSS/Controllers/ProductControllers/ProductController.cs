using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoSS.Models.ProductModels;
using System.Numerics;

namespace PoSS.Controllers.ProductControllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        //As an inventory manager, I want to create a product so that finished products, sold by the business, are available in the catalog and tracked by the system.
        [HttpPost(Name = "CreateProduct")]
        public IActionResult CreateProduct([FromBody] Product value)
        {
            return Ok();
        }

        //As an inventory manager, I want to view product details so that I can review how the product is described to the clients.
        [HttpGet(Name = "GetProduct/{id}")]
        public IActionResult GetProduct(int id)
        {
            return Ok();
        }

        [HttpGet(Name = "GetProducts")]
        public IActionResult GetProducts()
        {
            return Ok();
        }

        //As an inventory manager, I want to update product details.
        [HttpPut(Name = "UpdateProduct/{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] Product value)
        {
            if (id != value.id)
            {
                return BadRequest();
            }
            return Ok();
        }

        //As an inventory manager, I want to retire a product so that it is no longer visible to the customers while preserving historical order data.
        [HttpPut(Name = "DisableProduct/{id}")]
        public IActionResult DisableProduct(int id, [FromBody] Product value)
        {
            if (id != value.id)
            {
                return BadRequest();
            }
            if (!value.is_disabled)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpPut(Name = "EnableProduct/{id}")]
        public IActionResult EnableProduct(int id, [FromBody] Product value)
        {
            if (id != value.id)
            {
                return BadRequest();
            }
            if (value.is_disabled)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpDelete(Name = "DeleteProduct/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            return Ok();
        }

    }
}
