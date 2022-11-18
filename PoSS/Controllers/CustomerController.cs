using Microsoft.AspNetCore.Mvc;
using PoSS.DTOs;
using System.ComponentModel.DataAnnotations;

namespace PoSS.Controllers
{
    [ApiController]
    public class CustomerController : Controller
    {
        /// <summary>
        /// Endpoint for creating a new customer account.
        /// </summary>
        /// <param name="tenantId">Id of the store customer is registering to.</param>
        /// <param name="accountDetails">Customer account details.</param>
        /// <returns>Returns a bearer token of newly created account</returns>
        /// <response code="201">Returns a bearer token of newly created account</response>
        /// <response code="400">If some account details are missing</response>
        /// <response code="400">If account details don't pass validation.</response>
        /// <response code="409">If email matches a previously registered users email</response>
        [HttpPost]
        [Route("{tenantId}/[controller]")]
        [ProducesResponseType(typeof(string), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public IActionResult Register(int tenantId, [Required] CreateAccountDTO accountDetails)
        {
            return Created(Request.Path.Value, new {token = "1df3g153g15er1g5er1gerg53..."});
        }

        /// <summary>
        /// Endpoint to get user account details.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{tenantId}/[controller]/{userId}")]
        [ProducesResponseType(typeof(AccountDetailsDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int userId)
        {
            return Ok(new AccountDetailsDTO());
        }

        /// <summary>
        /// Endpoint to update user account details.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="accountDetails">Customer account details.</param>
        /// <returns></returns>
        /// <response code="400">If some account details are missing</response>
        /// <response code="400">If account details don't pass validation.</response>
        [HttpPut]
        [Route("{tenantId}/[controller]/{userId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Put(int userId, CreateAccountDTO accountDetails)
        {
            return Ok();
        }

        /// <summary>
        /// Endpoint for loging in.
        /// </summary>
        /// <returns>Returns a bearer token.</returns>
        [HttpPost]
        [Route("{tenantId}/[controller]/login")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public IActionResult Login()
        {
            return Ok(new {token = "1df3g153g15er1g5er1gerg53..."});
        }
    }
}
