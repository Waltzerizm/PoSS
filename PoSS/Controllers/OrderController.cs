using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoSS.DTOs;

namespace PoSS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        /// <summary>
        /// Gets order by id.
        /// </summary>
        /// <param name="tenantId">Id of the tenant.</param>
        /// <param name="orderId">Id of the order.</param>
        /// <returns>Returns order information</returns>
        /// <response code="200">Returns order information.</response>
        /// <response code="404">If order doesn't exist.</response>
        [HttpGet]
        [Route("{tenantId}/Order/{orderId}")]
        [ProducesResponseType(typeof(OrderDTO), 200)]
        public IActionResult GetOrder(int tenantId, int orderId)
        {
            return Ok(new OrderDTO());
        }

        /// <summary>
        /// Creates and order.
        /// </summary>
        /// <param name="tenantId">Id of the tenant.</param>
        /// <param name="order">Information required to create an order.</param>
        /// <returns>Returns information of the newly created order.</returns>
        /// <response code="200">Returns information of the newly created order.</response>
        [HttpPost]
        [Route("{tenantId}/Order")]
        [ProducesResponseType(typeof(OrderDTO), 200)]
        public IActionResult CreateOrder(int tenantId, CreateOrderDTO order)
        {
            return Ok(new OrderDTO());
        }

        /// <summary>
        /// Creates and order from a cart.
        /// </summary>
        /// <param name="tenantId">Id of the tenant.</param>
        /// <param name="cartId">Id of the cart.</param>
        /// <returns>Returns information of the newly created order.</returns>
        /// <response code="200">Returns information of the newly created order.</response>
        /// <response code="404">If cart doesn't exists.</response>
        [HttpPost]
        [Route("{teantId}/Cart/{cartId}/Order")]
        [ProducesResponseType(typeof(OrderDTO), 200)]
        public IActionResult CreateOrderFromCart(int tenantId, int cartId)
        {
            return Ok(new OrderDTO());
        }

        /// <summary>
        /// Links a payment to an order.
        /// </summary>
        /// <param name="tenantId">Id of the tenant.</param>
        /// <param name="orderId">Id of the order.</param>
        /// <param name="payment">Payment information.</param>
        /// <returns>Returns payment information.</returns>
        /// <response code="200">Returns payment information.</response>
        /// <response code="400">If paid with digital money, but change field is filled.</response>
        /// <response code="404">If order doesn't exists.</response>
        [HttpPost]
        [Route("{tenantId}/Order/{orderId}/Payment")]
        [ProducesResponseType(typeof(PaymentDTO), 200)]
        public IActionResult PayForOrder(int tenantId, int orderId, PaymentDTO payment)
        {
            return Ok(new PaymentDTO());
        }

        /// <summary>
        /// Refunds an order.
        /// </summary>
        /// <remarks>
        /// This endpoint can only be used by an authorised service providers.
        /// </remarks>
        /// <param name="tenantId">Id of the tenant.</param>
        /// <param name="orderId">Id of the order.</param>
        /// <returns>Returns a response that order was refunded successfully.</returns>
        /// <response code="200">Returns a response that order was refunded successfully.</response>
        /// <response code="404">If order doesn't exists.</response>
        [HttpPost]
        [Route("{tenantId}/Order/{orderId}/Refund")]
        public IActionResult RefundOrder(int tenantId, int orderId)
        {
            return Ok();
        }
    }
}
