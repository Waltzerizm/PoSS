using Microsoft.AspNetCore.Mvc;
using PoSS.Models;

namespace PoSS.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ServiceController : ControllerBase
    {

        // BO6.	As a business owner, I want to manage services provided by the business

        [HttpPost(Name = "CreateService")]
        public IActionResult CreateService(Service service)
        {
            return Ok();
        }

        [HttpGet(Name = "GetService")]
        public ActionResult<Service> GetService(int id)
        {
            return Ok(new Service());
        }

        [HttpPut(Name = "UpdateService")]
        public IActionResult UpdateService(Service service)
        {
            return Ok();
        }

        [HttpDelete(Name = "DeleteService")]
        public IActionResult DeleteService(int id)
        {
            return Ok();
        }
    }
}