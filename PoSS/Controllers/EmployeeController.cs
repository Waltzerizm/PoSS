using Microsoft.AspNetCore.Mvc;
using PoSS.Models;
using GenFu;

namespace PoSS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("GetAllEmployees")]
        public ActionResult<Employee> GetAllEmployees([FromQuery] int objectCount)
        {
            if (objectCount < 0)
            {
                return BadRequest();
            }

            A.Configure<Employee>()
                .Fill(e => e.Id).WithinRange(1, objectCount);

            return Ok(A.ListOf<Employee>(objectCount)); // return random generated list of items
        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("GetEmployeeById")]
        public ActionResult<Employee> GetEmployeeById([FromQuery] int employeeId)
        {
            if (employeeId <= 0)
            {
                return BadRequest();
            }

            A.Configure<Employee>()
                .Fill(e => e.Id, employeeId);
            return Ok(A.New<Employee>()); // return random generated item by id
        }

        // As an HR manager, I want to add a new employee to the system.
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("CreateEmployee")]
        public ActionResult CreateEmployee([FromBody] Employee newObject)
        {
            return Ok();
        }

        // As an HR manager, I want to edit employee account details.
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("UpdateEmployee")]
        public ActionResult UpdateEmployee([FromBody] Employee newObject)
        {
            return Ok();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("DeleteEmployee")]
        public ActionResult DeleteEmployee([FromQuery] int employeeId)
        {
            if (employeeId <= 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        // As an HR manager I want to hide old employee accounts.
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPatch("HideEmployee")]
        public ActionResult HideEmployee([FromQuery] int employeeId, [FromBody] DateTime date)
        {
            if (employeeId <= 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        // As an HR manager I want to assign employee account permissions so that promoted employees would have additional access rights.
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPatch("ChangeEmployeePermissions")]
        public ActionResult ChangeEmployeePermissions([FromQuery] int employeeId, [FromQuery] int permissionId)
        {
            if (employeeId <= 0 && permissionId <= 0)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
