using Microsoft.AspNetCore.Mvc;
using PoSS.Models;

namespace PoSS.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class LocationController : ControllerBase
    {
        // BO5.	As a business owner, I want to manage the locations of my business.

        [HttpPost(Name = "CreateLocation")]
        public IActionResult CreateLocation(Location location)
        {
            return Ok();
        }

        [HttpGet(Name = "GetLocation")]
        public ActionResult<Location> GetLocation(int locationId)
        {
            return Ok(new Location());
        }

        [HttpPut(Name = "UpdateLocation")]
        public IActionResult UpdateLocation(Location location)
        {
            return Ok();
        }

        [HttpDelete(Name = "DeleteLocation")]
        public IActionResult DeleteLocation(int locationId)
        {
            return Ok();
        }
    }
}