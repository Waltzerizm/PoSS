using Microsoft.AspNetCore.Mvc;

namespace PoSS.Controllers
{
    /// <summary>
    /// Controller for reports.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ReportController : ControllerBase
    {
        // A5.	As an accountant I want to create a detailed sales report so that I can calculate the relevant taxes and provide necessary financial data to the government. 
        /// <summary>
        /// Endpoint for getting reports.
        /// TODO: Figure out the format of a sales report.
        /// </summary>
        [HttpGet("DetailedSalesReport")]
        public IActionResult GetDetailedSalesReport()
        {
            return Ok();
        }
    }
}