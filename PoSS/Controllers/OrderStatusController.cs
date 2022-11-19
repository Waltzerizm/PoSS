using Microsoft.AspNetCore.Mvc;
using PoSS.Models;
using PoSS.Enums;
using GenFu;

namespace PoSS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderStatusController : ControllerBase
    {
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("GetAllOrderStatus")]
        public ActionResult<OrderStatus> GetAllOrderStatus([FromQuery] int objectCount)
        {
            if (objectCount < 0)
            {
                return BadRequest();
            }

            A.Configure<OrderStatus>()
                .Fill(e => e.Id).WithinRange(1, objectCount);

            return Ok(A.ListOf<OrderStatus>(objectCount)); // return random generated list of items
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("GetOrderStatusById")]
        public ActionResult<OrderStatus> GetOrderStatusById([FromQuery] int orderStatusId)
        {
            if (orderStatusId <= 0)
            {
                return BadRequest();
            }

            A.Configure<OrderStatus>()
                .Fill(e => e.Id, orderStatusId);
            return Ok(A.New<OrderStatus>()); // return random generated item by id
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("CreateOrderStatus")]
        public ActionResult CreateOrderStatus([FromBody] OrderStatus newOrderStatus)
        {
            return Ok();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("UpdateOrderStatus")]
        public ActionResult UpdateOrderStatus([FromBody] OrderStatus newOrderStatus)
        {
            return Ok();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("DeleteOrderStatus")]
        public ActionResult DeleteOrderStatus([FromQuery] int orderStatusId)
        {
            if (orderStatusId <= 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        // As a service provider, I want to have an ability to cancel a customer’s booking
        // if I will not be able to provide the service due to unexpected issues. 
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPatch("UpdateOrderStatus")]
        public ActionResult UpdateOrderStatus([FromQuery] int orderStatusId, [FromBody] OrderStatusTypes newOrderStatus)
        {
            if (orderStatusId <= 0)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
