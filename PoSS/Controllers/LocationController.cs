using Microsoft.AspNetCore.Mvc;

namespace PoSS.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class LocationController : ControllerBase
    {
        // BO5.	As a business owner, I want to manage the locations of my business.

        [HttpPost(Name = "CreateLocation")]
        public IActionResult CreateLocation()
        {
            return Ok();
        }

        [HttpGet(Name = "GetLocation")]
        public IActionResult GetLocation()
        {
            return Ok();
        }

        [HttpPut(Name = "UpdateLocation")]
        public IActionResult UpdateLocation()
        {
            return Ok();
        }

        [HttpDelete(Name = "DeleteLocation")]
        public IActionResult DeleteLocation()
        {
            return Ok();
        }
    }
}