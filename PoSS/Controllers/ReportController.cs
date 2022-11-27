using Microsoft.AspNetCore.Mvc;
using PoSS.DTOs;

namespace PoSS.Controllers
{
    /// <summary>
    /// Controller for reports.
    /// </summary>
    [ApiController]
    [Route("{tenantId}/[controller]")]
    public class ReportController : ControllerBase
    {
        // A5.	As an accountant I want to create a detailed sales report so that I can calculate the relevant taxes and provide necessary financial data to the government. 
        /// <summary>
        /// Endpoint to get detailed sales report.
        /// </summary>
        /// <param name="tenantId">Id of the store.</param>
        [HttpGet("DetailedSalesReport")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public ActionResult<DetailedSalesReportDTO> GetDetailedSalesReport(int tenantId)
        {
            return Ok();
        }

        /// <summary>
        /// Endpoint to get brief sales report.
        /// </summary>
        /// <param name="tenantId">Id of the store.</param>
        [HttpGet("BriefSalesReport")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public ActionResult<BriefSalesReportDTO> GetBriefSalesReport(int tenantId)
        {
            return Ok();
        }

    }
}