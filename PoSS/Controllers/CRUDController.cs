using Microsoft.AspNetCore.Mvc;

namespace PoSS.Controllers
{
    /// <summary>
    /// Base controller for managing CRUD operations.
    /// </summary>
    public class CRUDController<T, TDto> : ControllerBase
    {
        /// <summary>
        /// Endpoint to get multiple items.
        /// </summary>
        /// <param name="pageSize">The maximum amount of items in response.</param>
        /// <param name="pageNumber">The page number of items to return.</param>
        /// <returns>A list of items.</returns>
        [HttpGet("{pageSize}/{pageNumber}")]
        public ActionResult<IEnumerable<TDto>> Get(int pageSize, int pageNumber)
        {
            return Ok();
        }

        /// <summary>
        /// Endpoint to get a single item.
        /// </summary>
        /// <param name="id">Id of the item to get</param>
        /// <returns>Item with the given id.</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<TDto> Get(int id)
        {
            return Ok();
        }

        /// <summary>
        /// Endpoint to create a new item.
        /// </summary>
        /// <param name="item">Item to create.</param>
        [HttpPost]
        public IActionResult Post([FromBody] TDto item)
        {
            return Ok();
        }

        /// <summary>
        /// Endpoint to update an item.
        /// </summary>
        /// <param name="id">Id of the item to update.</param>
        /// <param name="item">Item to update.</param>
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TDto item)
        {
            return Ok();
        }

        /// <summary>
        /// Endpoint to delete an item.
        /// </summary>
        /// <param name="id">Id of the item to delete.</param>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
       
    }
}