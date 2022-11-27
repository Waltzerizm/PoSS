using Microsoft.AspNetCore.Mvc;
using PoSS.Models;
using PoSS.Enums;
using PoSS.DTOs;

namespace PoSS.Controllers
{
    [Route("{tenantId}/[controller]")]
    [ApiController]
    public class OrderStatusController : ControllerBase
    {
        /// <summary>
        /// Gets order status
        /// </summary>
        /// <param name="orderStatusId"></param>
        /// <returns>Returns the status of the order</returns>
        /// <response code="200">Returns order status</response>
        /// <response code="400">If order status ID is less or equal to 0</response>
        /// <response code="404">If no orderstatus ID matched the search</response>
        [HttpGet]
        [Route("{orderStatusId}")]
        [ProducesResponseType(typeof(OrderStatusDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<OrderStatusDTO> GetOrderStatus(int tenantId, int orderStatusId)
        {
            if (orderStatusId <= 0)
            {
                return BadRequest();
            }

            return Ok(new OrderStatusDTO()); // return random generated item by id
        }

        /// <summary>
        /// Creates order status
        /// </summary>
        /// <param name="newOrderStatus"></param>
        /// <returns></returns>
        /// <response code="201">If order status has been succesfully created</response>
        /// <response code="400">If provided order status details do not pass the validation</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult CreateOrderStatus(int tenantId, OrderStatusDTO newOrderStatus)
        {
            return Ok();
        }

        /// <summary>
        /// Updates order status
        /// </summary>
        /// <param name="orderStatusId"></param>
        /// <param name="newOrderStatus"></param>
        /// <returns></returns>
        /// <response code="200">If order status have been succesfully updated</response>
        /// <response code="400">If provided order status details do not pass the validation</response>
        /// <response code="404">If no order status ID matched the search</response>
        [HttpPut]
        [Route("{orderStatusId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult UpdateOrderStatus(int tenantId, int orderStatusId, OrderStatusDTO newOrderStatus)
        {
            if (orderStatusId <= 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        /// <summary>
        /// Deletes order status
        /// </summary>
        /// <param name="orderStatusId"></param>
        /// <returns></returns>
        /// <response code="200">If order status have been succesfully delete</response>
        /// <response code="400">If provided order status details do not pass the validation</response>
        /// <response code="404">If no order status ID matched the search</response>
        [HttpDelete]
        [Route("{orderStatusId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult DeleteOrderStatus(int tenantId, int orderStatusId)
        {
            if (orderStatusId <= 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        // As a service provider, I want to have an ability to cancel a customer’s booking
        // if I will not be able to provide the service due to unexpected issues.
        /// <summary>
        /// Updates order status
        /// </summary>
        /// <param name="orderStatusId"></param>
        /// <param name="newOrderStatus"></param>
        /// <returns></returns>
        /// <response code="200">If order status have been succesfully updated</response>
        /// <response code="400">If order status ID is less or equal to 0</response>
        /// <response code="400">If the provided order status enum value is invalid</response>
        /// <response code="404">If no order status ID matched the search</response>
        [HttpPatch]
        [Route("{orderStatusId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult UpdateOrderStatus(int tenantId, int orderStatusId, OrderStatusTypes newOrderStatus)
        {
            if (orderStatusId <= 0)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
