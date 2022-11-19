using Microsoft.AspNetCore.Mvc;
using PoSS.Models;
using GenFu;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PoSS.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public ActionResult<EmployeePermission> GetAllPermissions([FromQuery] int objectCount)
        {
            A.Configure<EmployeePermission>()
                .Fill(e => e.EmployeeId).WithinRange(1, objectCount);

            return Ok(A.ListOf<EmployeePermission>(objectCount)); // return random generated list of items
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public ActionResult<EmployeePermission> GetPermissionById([FromQuery] int permissionId)
        {
            A.Configure<EmployeePermission>()
                .Fill(e => e.EmployeeId, permissionId);
            return Ok(A.New<EmployeePermission>()); // return random generated item by id
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public ActionResult CreatePermission([FromBody] EmployeePermission newPermission)
        {
            return Ok();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut]
        public ActionResult UpdatePermission([FromBody] Permission newPermission)
        {
            return Ok();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete]
        public ActionResult DeletePermission([FromQuery] int permissionId)
        {
            return Ok();
        }
    }
}
