using Microsoft.AspNetCore.Mvc;
using PoSS.Models;
using PoSS.DTOs;

namespace PoSS.Controllers
{
    [Route("{tenantId}/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// Gets employee details
        /// </summary>
        /// <param name="employeeId">ID of the employee</param>
        /// <returns>Returns the details of the employee</returns>
        /// <response code="200">Returns employee details</response>
        /// <response code="400">If employee ID is less or equal to 0</response>
        /// <response code="404">If no employee ID matched the search</response>
        [HttpGet]
        [Route("{employeeId}")]
        [ProducesResponseType(typeof(EmployeeDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<EmployeeDTO> GetEmployee(int tenantId, int employeeId)
        {
            if (employeeId <= 0)
            {
                return BadRequest();
            }

            return Ok(new EmployeeDTO());
        }

        // As an HR manager, I want to add a new employee to the system.
        /// <summary>
        /// Creates an employee
        /// </summary>
        /// <param name="newEmployee"></param>
        /// <returns></returns>
        /// <response code="201">If employee has been succesfully created</response>
        /// <response code="400">If provided employee details do not pass the validation</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult CreateEmployee(int tenantId, EmployeeDTO newEmployee)
        {
            return Ok();
        }

        // As an HR manager, I want to edit employee account details.
        /// <summary>
        /// Updates employee details
        /// </summary>
        /// <param name="newEmployee"></param>
        /// <returns></returns>
        /// <response code="200">If employee details have been succesfully updated</response>
        /// <response code="400">If provided employee details do not pass the validation</response>
        /// <response code="404">If no employee ID matched the search</response>
        [HttpPut]
        [Route("{employeeId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult UpdateEmployee(int tenantId, int employeeId, EmployeeDTO newEmployee)
        {
            if (employeeId <= 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        /// <summary>
        /// Deletes employee
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        /// <response code="200">If employee have been succesfully deleted</response>
        /// <response code="400">If employee ID is less or equal to 0</response>
        /// <response code="404">If no employee ID matched the search</response>
        [HttpDelete]
        [Route("{employeeId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult DeleteEmployee(int tenantId, int employeeId)
        {
            if (employeeId <= 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        // As an HR manager I want to hide old employee accounts.
        /// <summary>
        /// Hides the employee
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        /// <response code="200">If employee have been succesfully hiden</response>
        /// <response code="400">If employee ID is less or equal to 0</response>
        /// <response code="400">If invalid date provided</response>
        /// <response code="404">If no employee ID matched the search</response>
        [HttpPatch]
        [Route("{employeeId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult HideEmployee(int tenantId, int employeeId, DateTime date)
        {
            if (employeeId <= 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        // As an HR manager I want to assign employee account permissions so that promoted employees would have additional access rights.
        /// <summary>
        /// Changes employee permissions
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="permissionId"></param>
        /// <returns></returns>
        /// <response code="200">If the employee permissions have been succesfully updated</response>
        /// <response code="400">If employee ID is less or equal to 0</response>
        /// <response code="404">If no employee ID matched the search</response>
        /// <response code="404">If no permission ID matched the search</response>
        [HttpPatch]
        [Route("{employeeId}/{permissionId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult ChangeEmployeePermissions(int tenantId, int employeeId, int permissionId)
        {
            if (employeeId <= 0 && permissionId <= 0)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
