using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PoSS.DTOs;

namespace PoSS.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AccountController : ControllerBase
    {

        // BO1.	As a business owner, I want to create a business account so that the system functionality is available to my business.
        [HttpPost(Name = "CreateAccount")]
        public IActionResult CreateAccount()
        {
            return Ok();
        }

        // BO2.	As a business owner, I want to access my business account so that I could use the functionality provided to my business.
        [HttpGet(Name = "Authenticate")]
        public ActionResult<string> Authenticate([FromBody] CredentialsDto credentials)
        {
            return Ok("12345");
        }

        // BO3.	As a business owner, I want to update my business account details.
        [HttpPut(Name = "UpdateAccount")]
        public IActionResult UpdateAccount()
        {
            return Ok();
        }

        // BO4.	As a business owner, I want to delete my business account so that my business data is deleted from the system when I stop using the service.
        [HttpDelete(Name = "DeleteAccount")]
        public IActionResult DeleteAccount()
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