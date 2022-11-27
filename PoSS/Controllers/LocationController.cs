using Microsoft.AspNetCore.Mvc;
using PoSS.DTOs;
using PoSS.Models;

namespace PoSS.Controllers
{
    /// <summary>
    /// Controller for managing business locations.
    /// </summary>
    [ApiController]
    [Route("{tenantId}/[controller]/[action]")]
    public class LocationController: ControllerBase
    {
        /// <summary>
        /// Endpoint to get multiple business locations.
        /// </summary>
        /// <param name="pageSize">The maximum amount of business locations in response.</param>
        /// <param name="pageNumber">The page number of business locations to return.</param>
        /// <param name="tenantId">Id of the store.</param>
        /// <returns>A list of business locations.</returns>
        [HttpGet("{pageSize}/{pageNumber}")]
        public ActionResult<IEnumerable<Location>> Get(int tenantId, int pageSize, int pageNumber)
        {
            return Ok();
        }

        /// <summary>
        /// Endpoint to get a single business location.
        /// </summary>
        /// <param name="id">Id of the business location to get</param>
        /// <param name="tenantId">Id of the store.</param>
        /// <returns>Business location with the given id.</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<LocationDto> Get(int tenantId, int id)
        {
            return Ok();
        }

        /// <summary>
        /// Endpoint to create a new business location.
        /// </summary>
        /// <param name="item">Business location to create.</param>
        /// <param name="tenantId">Id of the store.</param>
        [HttpPost]
        public IActionResult Post(int tenantId, [FromBody] LocationDto item)
        {
            return Ok();
        }

        /// <summary>
        /// Endpoint to update a business location.
        /// </summary>
        /// <param name="id">Id of the business location to update.</param>
        /// <param name="item">Business location to update.</param>
        /// <param name="tenantId">Id of the store.</param>
        [HttpPut("{id}")]
        public IActionResult Put(int tenantId, int id, [FromBody] LocationDto item)
        {
            return Ok();
        }

        /// <summary>
        /// Endpoint to delete a business location.
        /// </summary>
        /// <param name="id">Id of the business location to delete.</param>
        /// <param name="tenantId">Id of the store.</param>
        [HttpDelete("{id}")]
        public IActionResult Delete(int tenantId, int id)
        {
            return Ok();
        }
    }
}