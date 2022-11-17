using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PoSS.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BusinessOwnerController : ControllerBase
    {

        // BO1.	As a business owner, I want to create a business account so that the system functionality is available to my business.
        [HttpPost(Name = "CreateBusinessOwner")]
        public IActionResult CreateBusinessOwner()
        {
            return Ok();
        }

        // BO2.	As a business owner, I want to access my business account so that I could use the functionality provided to my business.
        [HttpGet(Name = "GetBusinessOwner")]
        public IActionResult GetBusinessOwner()
        {
            return Ok();
        }

        // BO3.	As a business owner, I want to update my business account details.
        [HttpPut(Name = "UpdateBusinessOwner")]
        public IActionResult UpdateBusinessOwner()
        {
            return Ok();
        }

        // BO4.	As a business owner, I want to delete my business account so that my business data is deleted from the system when I stop using the service.
        [HttpDelete(Name = "DeleteBusinessOwner")]
        public IActionResult DeleteBusinessOwner()
        {
            return Ok();
        }

        // BO14.	As a business owner, I want to create a brief sales report to find the most popular products and/or the best performing services in my business.
        [HttpGet(Name = "CreateSalesReport")]
        public IActionResult CreateSalesReport()
        {
            return Ok();
        }
    }
}