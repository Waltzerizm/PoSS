using Microsoft.AspNetCore.Mvc;

namespace PoSS.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ServiceController : ControllerBase
    {

        // BO6.	As a business owner, I want to manage services provided by the business

        [HttpPost(Name = "CreateService")]
        public IActionResult CreateService()
        {
            return Ok();
        }

        [HttpGet(Name = "GetService")]
        public IActionResult GetService()
        {
            return Ok();
        }

        [HttpPut(Name = "UpdateService")]
        public IActionResult UpdateService()
        {
            return Ok();
        }

        [HttpDelete(Name = "DeleteService")]
        public IActionResult DeleteService()
        {
            return Ok();
        }
    }
}