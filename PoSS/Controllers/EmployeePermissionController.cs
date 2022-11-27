using Microsoft.AspNetCore.Mvc;
using PoSS.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PoSS.Controllers
{
    [Route("{tenantId}/[controller]")]
    [ApiController]
    public class EmployeePermissionController : ControllerBase
    {
        /// <summary>
        /// Gets permission details
        /// </summary>
        /// <param name="employeeId">ID of the permission</param>
        /// <returns>Returns the details of the permissions</returns>
        /// <response code="200">Returns permissions</response>
        /// <response code="400">If permission ID is less or equal to 0</response>
        /// <response code="404">If no permission ID matched the search</response>
        [HttpGet]
        [Route("{employeeId}")]
        [ProducesResponseType(typeof(EmployeePermissionDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<EmployeePermissionDTO> GetPermission(int tenantId, int permissionId)
        {
            if (permissionId <= 0)
            {
                return BadRequest();
            }
            
            return Ok(new EmployeePermissionDTO());
        }
        /// <summary>
        /// Creates a permission
        /// </summary>
        /// <param name="newPermission"></param>
        /// <returns></returns>
        /// <response code="201">If permission has been succesfully created</response>
        /// <response code="400">If provided permission details do not pass the validation</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult CreatePermission(int tenantId, EmployeePermissionDTO newPermission)
        {
            return Ok();
        }

        /// <summary>
        /// Updates permission details
        /// </summary>
        /// <param name="newPermission"></param>
        /// <returns></returns>
        /// <response code="200">If permission details hae been succesfully updates</response>
        /// <response code="400">If provided permission details do not pass the validation</response>
        /// <response code="404">If no permission ID matched the search</response>
        [HttpPut]
        [Route("{permissionId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult UpdatePermission(int tenantId, int permissionId, EmployeePermissionDTO newPermission)
        {
            if (permissionId <= 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        /// <summary>
        /// Deletes permission
        /// </summary>
        /// <param name="permissionId"></param>
        /// <returns></returns>
        /// <response code="200">If permission has been succesfully deleted</response>
        /// <response code="400">If permission ID is less or equal to 0</response>
        /// <response code="404">If no permission ID matched the search</response>
        [HttpDelete]
        [Route("{permissionId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult DeletePermission(int tenantId, int permissionId)
        {
            if (permissionId <= 0)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
