using Microsoft.AspNetCore.Mvc;

namespace PoSS.Controllers
{

    [ApiController]
    [Route("[controller]/[action]")]
    public class TaxRateController : ControllerBase
    {
        // A1.	As an accountant, I want to create a new tax rate so that it can be reused across multiple products.
        [HttpPost(Name = "CreateTaxRate")]
        public IActionResult CreateTaxRate()
        {
            return Ok();
        }

        [HttpGet(Name = "GetTaxRate")]
        public IActionResult GetTaxRate()
        {
            return Ok();
        }

        [HttpPut(Name = "UpdateTaxRate")]
        public IActionResult UpdateTaxRate()
        {
            return Ok();
        }

        [HttpDelete(Name = "DeleteTaxRate")]
        public IActionResult DeleteTaxRate()
        {
            return Ok();
        }

        // A3.	As an accountant, I want to assign tax rate to products so that ordered products are automatically taxed according to the law.
        [HttpPost(Name = "AssignTaxRateToItem")]
        public IActionResult AssignTaxRateToItem()
        {
            return Ok();
        }

        // A4.	As an accountant, I want to apply tax rate to categories so that all products in the selected category are assigned the same tax rate automatically.
        [HttpPost(Name = "AssignTaxRateToCategory")]
        public IActionResult AssignTaxRateToCategory()
        {
            return Ok();
        }

        // A5.	As an accountant I want to create a detailed sales report so that I can calculate the relevant taxes and provide necessary financial data to the government. 
        [HttpGet(Name = "GetSalesReport")]
        public IActionResult GetSalesReport()
        {
            return Ok();
        }
    }
}
