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
        /// <param name="orderId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{orderId}")]
        public IActionResult GetOrder(int orderId)
        {
            return Ok(new OrderDTO());
        }

        /// <summary>
        /// Creates and order.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateOrder(CreateOrderDTO order)
        {
            return Ok(new OrderDTO());
        }

        /// <summary>
        /// Creates and order from a cart.
        /// </summary>
        /// <param name="cartId"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("cart/{cartId}")]
        public IActionResult CreateOrderFromCart(int cartId)
        {
            return Ok(new OrderDTO());
        }

        /// <summary>
        /// Refunds an order.
        /// </summary>
        /// <remarks>
        /// This endpoint can only be used by authorised service providers.
        /// </remarks>
        /// <param name="orderId"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("{orderId}")]
        public IActionResult RefundOrder(int orderId)
        {
            return Ok();
        }

        /// <summary>
        /// Simply adds a payment to an order. Creating a whole payment system is out of scope of this assignment. :)))
        /// </summary>
        /// <param name="payment"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("{orderId}/payment")]
        public IActionResult PayForOrder(PaymentDTO payment)
        {
            return Ok(payment);
        }


    }
}
