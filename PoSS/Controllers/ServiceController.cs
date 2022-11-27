using Microsoft.AspNetCore.Mvc;
using PoSS.DTOs;
using PoSS.Models;

namespace PoSS.Controllers
{
    /// <summary>
    /// Controller for managing services.
    /// </summary>
    [ApiController]
    [Route("{tenantId}/[controller]")]
    public class ServiceController : ControllerBase
    {
        /// <summary>
        /// Endpoint to get multiple services.
        /// </summary>
        /// <param name="pageSize">The maximum amount of services in response.</param>
        /// <param name="pageNumber">The page number of services to return.</param>
        /// <param name="tenantId">Id of the store.</param>
        /// <returns>A list of services.</returns>
        [HttpGet("{pageSize}/{pageNumber}")]
        public ActionResult<IEnumerable<Service>> Get(int tenantId, int pageSize, int pageNumber)
        {
            return Ok();
        }

        /// <summary>
        /// Endpoint to get a single service.
        /// </summary>
        /// <param name="id">Id of the service to get</param>
        /// <param name="tenantId">Id of the store.</param>
        /// <returns>Service with the given id.</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Service> Get(int tenantId, int id)
        {
            return Ok();
        }

        /// <summary>
        /// Endpoint to create a new service.
        /// </summary>
        /// <param name="service">Service to create.</param>
        [HttpPost]
        public IActionResult Post([FromBody] ServiceDto service)
        {
            return Ok();
        }

        /// <summary>
        /// Endpoint to update a service.
        /// </summary>
        /// <param name="id">Id of the service to update.</param>
        /// <param name="service">Service to update.</param>
        /// <param name="tenantId">Id of the store.</param>
        [HttpPut("{id}")]
        public IActionResult Put(int tenantId, int id, [FromBody] ServiceDto service)
        {
            return Ok();
        }

        /// <summary>
        /// Endpoint to delete a service.
        /// </summary>
        /// <param name="id">Id of the service to delete.</param>
        /// <param name="tenantId">Id of the store.</param>
        [HttpDelete("{id}")]
        public IActionResult Delete(int tenantId, int id)
        {
            return Ok();
        }
    }
}