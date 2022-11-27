using Microsoft.AspNetCore.Mvc;
using PoSS.DTOs;

namespace PoSS.Controllers
{
    /// <summary>
    /// Controller for tenants.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class TenantController: ControllerBase
    {
        /// <summary>
        /// Endpoint to create a new store.
        /// </summary>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult CreateTenant(CreateTenantAccountDTO dto)
        {
            return Ok();
        }

        /// <summary>
        /// Endpoint to get the details of a store.
        /// </summary>
        [HttpGet("{tenantId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<TenantAccountDetailsDTO> GetTenantDetails(int tenantId)
        {
            return Ok();
        }

        /// <summary>
        /// Endpoint to login to a store.
        /// </summary>
        [HttpPost("login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<TokenDTO> Login(CredentialsDto dto)
        {
            return Ok();
        }

        /// <summary>
        /// Endpoint to update a store.
        /// </summary>
        /// <param name="tenantId">Id of the store.</param>
        /// <param name="dto"></param>
        [HttpPut("{tenantId}")]
        public ActionResult UpdateTenant(int tenantId, CreateTenantAccountDTO dto)
        {
            return Ok();
        }

        /// <summary>
        /// Endpoint to delete a store.
        /// </summary>
        /// <param name="tenantId">Id of the store.</param>
        [HttpDelete]
        public ActionResult DeleteTenant(int tenantId)
        {
            return Ok();
        }


    }
}