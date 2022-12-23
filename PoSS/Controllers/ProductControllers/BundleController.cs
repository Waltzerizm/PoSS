using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoSS.Models.ProductModels;
using System;
using System.Numerics;
using PoSS.DTOs.ProductDTOs;

namespace PoSS.Controllers.ProductControllers
{
    [ApiController]
    [Route("{tenantId}/[controller]")]
    public class BundleController : ControllerBase
    {
        //As an inventory manager, I want to manage bundles so that common sets of products can be purchased at a special price.
        /// <summary>
        /// Create bundle.
        /// </summary>
        /// <param name="bundle"></param>
        /// <returns></returns>
        /// <response code="400">If some bundle details are missing.</response>
        [HttpPost]
        public IActionResult CreateBundle(BundleDTO bundle)
        {
            return Ok();
        }

        /// <summary>
        /// Get bundle by Id.
        /// </summary>
        /// <param name="bundleId"></param>
        /// <returns></returns>
        /// <response code="404">If bundle with such id does not exist.</response>
        [HttpGet]
        [Route("{bundleId}")]
        [ProducesResponseType(typeof(BundleDTO), StatusCodes.Status200OK)]
        public IActionResult GetBundle(int bundleId)
        {
            return Ok(new BundleDTO());
        }

        /// <summary>
        /// Get a list of bundles.
        /// </summary>
        /// <param name="pageSize">Parameter to define how many records are in a page.</param>
        /// <param name="pageNumber">Parameter to specify which page of records to return.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{pageSize}/{pageNumber}")]
        [ProducesResponseType(typeof(List<BundleDTO>), StatusCodes.Status200OK)]
        public IActionResult GetBundles(int pageSize, int pageNumber)
        {
            return Ok(new List<BundleDTO>());
        }

        /// <summary>
        /// Update bundle by id.
        /// </summary>
        /// <param name="bundleId"></param>
        /// <param name="bundle"></param>
        /// <returns></returns>
        /// <response code="404">If bundle with such id does not exist.</response>
        /// <response code="400">If some bundle details are missing.</response>
        [HttpPut]
        [Route("{bundleId}")]
        public IActionResult UpdateBundle(int bundleId, BundleDTO bundle)
        {
            return Ok();
        }

        /// <summary>
        /// Delete bundle by id.
        /// </summary>
        /// <param name="bundleId"></param>
        /// <returns></returns>
        /// <response code="404">If bundle with such id does not exist.</response>
        [HttpDelete]
        [Route("{bundleId}")]
        public IActionResult DeleteBundle(int bundleId)
        {
            return Ok();
        }
    }
}
