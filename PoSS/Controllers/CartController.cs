using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoSS.DTOs;
using PoSS.Models;

namespace PoSS.Controllers
{
    [Route("{tenantId}/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="customerId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Customer/{customerId}")]
        public IActionResult GetCustomerCart(int tenantId, int customerId)
        {
            return Ok(new CartDTO());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cart"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateCart(CartDTO cart)
        {
            return Ok(new CartDTO());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cartId"></param>
        /// <param name="cartItem"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("{cartId}")]
        public IActionResult AddToCart(int cartId, CartItem cartItem)
        {
            return Ok(new CartItem());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cartId"></param>
        /// <param name="itemId"></param>
        /// <param name="cartItem"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{cartId}/item/{itemId}")]
        public IActionResult UpdateCartItem(int cartId, int itemId, CartItem cartItem)
        {
            return Ok(new CartItem());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cartId"></param>
        /// <param name="itemId"></param>
        /// <param name="cartItem"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("{cartId}/item/{itemId}")]
        public IActionResult DeleteCartItem(int cartId, int itemId, CartItem cartItem)
        {
            return Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="cartId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{cartId}")]
        public IActionResult GetCart(int tenantId, int cartId)
        {
            return Ok(new CartDTO());
        }
    }
}
