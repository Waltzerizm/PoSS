using Microsoft.AspNetCore.Mvc;
using PoSS.Models;

namespace PoSS.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class DiscountController : ControllerBase
    {

        // BO7.	As a business owner, I want to create a discount so that certain items can be purchased at special price for a limited time, leading to increased sales.

        [HttpPost(Name = "CreateDiscount")]
        public IActionResult CreateDiscount(Discount discount)
        {
            return Ok();
        }

        [HttpGet(Name = "GetDiscount")]
        public ActionResult<Discount> GetDiscount(int id)
        {
            return Ok();
        }

        [HttpPut(Name = "UpdateDiscount")]
        public IActionResult UpdateDiscount(Discount discount)
        {
            return Ok();
        }

        [HttpDelete(Name = "DeleteDiscount")]
        public IActionResult DeleteDiscount(int id)
        {
            return Ok();
        }

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