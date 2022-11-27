using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoSS.DTOs;
using PoSS.Models;

namespace PoSS.Controllers
{
    [ApiController]
    public class CartController : ControllerBase
    {
        /// <summary>
        /// Returns a cart of a specified customer.
        /// </summary>
        /// <param name="tenantId">Id of the tenant.</param>
        /// <param name="customerId">Id of the customer.</param>
        /// <returns>Returns a cart of a specified customer.</returns>
        /// <respnse code="200">Returns a cart of a specified customer.</respnse>
        /// <response code="404">If customer doesn't exist.</response>
        [HttpGet]
        [Route("{tenantId}/Customer/{customerId}/[controller]")]
        [ProducesResponseType(typeof(CartDTO), 200)]
        public IActionResult GetCustomerCart(int tenantId, int customerId)
        {
            return Ok(new CartDTO());
        }

        /// <summary>
        /// Creates a cart for a specified customer.
        /// </summary>
        /// <param name="tenantId">Id of the tenant.</param>
        /// <param name="customerId">Id of the customer.</param>
        /// <returns>Returns newly created cart.</returns>
        /// <response code="200">Returns newly created cart.</response>
        /// <response code="404">If customer doesn't exists.</response>
        [HttpPost]
        [Route("{tenantId}/[controller]")]
        [ProducesResponseType(typeof(CartDTO), 200)]
        public IActionResult CreateCart(int tenantId , [FromBody] int customerId)
        {
            return Ok(new CartDTO());
        }

        /// <summary>
        /// Adds an item to a cart.
        /// </summary>
        /// <param name="tenantId">Id of the tenant.</param>
        /// <param name="cartId">Id of the cart.</param>
        /// <param name="cartItem">Item to be added to the cart.</param>
        /// <returns>Returns newly added cart item.</returns>
        /// <response code="200">Returns newly added cart item.</response>
        /// <response code="404">If cart doen't exist.</response>
        /// <response code="400">If ids of both product and bundle are provided.</response>
        [HttpPost]
        [Route("{tenantId}/[controller]/CartId")]
        [ProducesResponseType(typeof(CartItemDTO), 200)]
        public IActionResult AddToCart (int tenantId, int cartId, AddCartItemDTO cartItem)
        {
            return Ok(new CartItemDTO());
        }

        /// <summary>
        /// Updates cart item.
        /// </summary>
        /// <remarks>
        /// If item quantity is set to 0, item should be removed from the cart.
        /// </remarks>
        /// <param name="tenantId">Id of the tenant.</param>
        /// <param name="itemId">Id of the cart item.</param>
        /// <param name="cartItem">Cart item with updated information.</param>
        /// <returns>Returns cart item with updated information.</returns>
        /// <response code="200">Returns cart item with updated information.</response>
        /// <response code="404">If cart item doesn't exist.</response>
        [HttpPut]
        [Route("{tenantId}/Cart/Item/{itemId}")]
        public IActionResult UpdateCartItem(int tenantId, int itemId, CartItem cartItem)
        {
            return Ok(new CartItemDTO());
        }

        /// <summary>
        /// Removes cart item from a cart.
        /// </summary>
        /// <param name="tenantId">Id of the tenant.</param>
        /// <param name="cartItemId">Id of the cart item.</param>
        /// <returns>Returns a response that cart item was removed successfully.</returns>
        /// <response code="200">Returns a response that cart item was removed successfully.</response>
        /// <response code="404">If cart item doesn't exist.</response>
        [HttpDelete]
        [Route("{tenantId}/Cart/Item/{cartItemId}")]
        public IActionResult DeleteCartItem(int tenantId, int cartItemId)
        {
            return Ok();
        }

        /// <summary>
        /// Get a cart by id.
        /// </summary>
        /// <param name="tenantId">Id of the tenant.</param>
        /// <param name="cartId">Id of the cart.</param>
        /// <returns>Returns the cart.</returns>
        /// <response code="200">Returns the cart.</response>
        /// <response code="404">If cart doesn't exist.</response>
        [HttpGet]
        [Route("{tenantId}/Cart/{cartId}")]
        [ProducesResponseType(typeof(CartDTO), 200)]
        public IActionResult GetCart(int tenantId, int cartId)
        {
            return Ok(new CartDTO());
        }
    }
}
