using Microsoft.AspNetCore.Mvc;
using PoSS.DTOs;
using PoSS.Models;

namespace PoSS.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class DiscountController : CRUDController<Discount, DiscountDto>
    {
        // BO11.	As a business owner, I want to assign a discount to a product or a service so that the discount is automatically applied when the product or service is purchased.
        [HttpPost(Name = "AssignDiscountToItem")]
        public IActionResult AssignDiscountToItem()
        {
            return Ok();
        }

        // BO12.	As a business owner, I want to assign a discount to a brand, so that the discount is automatically applied to any product made by the selected brand.
        [HttpPost(Name = "AssignDiscountToBrand")]
        public IActionResult AssignDiscountToBrand()
        {
            return Ok();
        }

        // BO13.	As a business owner, I want to assign a discount to a category, so that the discount is automatically applied to any product from the selected category.
        [HttpPost(Name = "AssignDiscountToCategory")]
        public IActionResult AssignDiscountToCategory()
        {
            return Ok();
        }
    }
}