using Microsoft.AspNetCore.Mvc;
using PoSS.DTOs;
using System.ComponentModel.DataAnnotations;

namespace PoSS.Controllers
{
    [ApiController]
    public class CustomerController : ControllerBase
    {
        /// <summary>
        /// Endpoint for creating a new customer account.
        /// </summary>
        /// <param name="tenantId">Id of the store customer is registering to.</param>
        /// <param name="accountDetails">Customer account details.</param>
        /// <returns>Returns a bearer token of newly created account.</returns>
        /// <response code="201">Returns a bearer token of newly created account.</response>
        /// <response code="400">If some account details are missing.</response>
        /// <response code="400">If account details don't pass validation.</response>
        /// <response code="409">If email matches a previously registered users email.</response>
        [HttpPost]
        [Route("{tenantId}/[controller]")]
        [ProducesResponseType(typeof(BearerTokenDTO), StatusCodes.Status201Created)]
        public IActionResult Register(int tenantId, [Required] CreateAccountDTO accountDetails)
        {
            return Created(Request.Path.Value, new BearerTokenDTO());
        }

        /// <summary>
        /// Endpoint to get user account details.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        /// <response code="404">If user doesn't exist</response>
        [HttpGet]
        [Route("{tenantId}/[controller]/{userId}")]
        [ProducesResponseType(typeof(AccountDetailsDTO), StatusCodes.Status200OK)]
        public IActionResult GetUserById(int userId)
        {
            return Ok(new AccountDetailsDTO());
        }

        /// <summary>
        /// Endpoint for admins to get a list of registered users.
        /// </summary>
        /// <param name="tenantId">Id of the tenant.</param>
        /// <param name="email">Optional parameter to query by email.</param>
        /// <param name="name">Optional parameter to query by name.</param>
        /// <param name="pageSize">Parameter to define how many records are in a page.</param>
        /// <param name="page">Parameter to specify which page of records to return.</param>
        /// <returns></returns>
        /// <response code="404">If user doesn't exist</response>
        [HttpGet]
        [Route("{tenantId}/[controller]")]
        [ProducesResponseType(typeof(List<AccountDetailsDTO>), StatusCodes.Status200OK)]
        public IActionResult GetUser
            (
            int tenantId,
            [FromQuery] string? email, 
            [FromQuery] string? name,
            [FromQuery] int? pageSize,
            [FromQuery] int? page
            )
        {
            return Ok(new AccountDetailsDTO[] { new AccountDetailsDTO() });
        }

        /// <summary>
        /// Endpoint to update user account details.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="accountDetails">Customer account details.</param>
        /// <returns></returns>
        /// <response code="400">If some account details are missing.</response>
        /// <response code="400">If account details don't pass validation.</response>
        /// <response code="404">If user doesn't exists.</response>
        [HttpPut]
        [Route("{tenantId}/[controller]/{userId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Put(int userId, CreateAccountDTO accountDetails)
        {
            return Ok();
        }

        /// <summary>
        /// Endpoint for customer to log in.
        /// </summary>
        /// <param name="loginDetails">Login details of the customer.</param>
        /// <returns>Returns a bearer token.</returns>
        [HttpPost]
        [Route("{tenantId}/[controller]/login")]
        [ProducesResponseType(typeof(BearerTokenDTO), StatusCodes.Status200OK)]
        public IActionResult Login([FromBody] LoginDetailsDTO loginDetails)
        {
            return Ok(new {token = "1df3g153g15er1g5er1gerg53..."});
        }
    }
}
