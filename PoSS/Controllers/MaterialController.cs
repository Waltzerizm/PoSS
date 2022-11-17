using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoSS.Models.ProductModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;

namespace PoSS.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class MaterialController : ControllerBase
    {
        //SHOULD
        //As an inventory manager, I want to manage raw materials that are used to make finished products. 
        [HttpPost(Name = "CreateMaterial")]
        public IActionResult CreateMaterial([FromBody] Material value)
        {
            return Ok();
        }

        //As an inventory manager, I want to manage a list of materials that are required to make a certain product so that the consumption of materials could be tracked.
        [HttpGet(Name = "GetMaterial/{id}")]
        public IActionResult GetMaterial(int id)
        {
            return Ok();
        }

        //As an inventory manager, I want to manage a list of materials that are required to make a certain product so that the consumption of materials could be tracked.
        [HttpGet(Name = "GetMaterials")]
        public IActionResult GetMaterials()
        {
            return Ok();
        }

        //As an inventory manager, I want to update the quantity of materials so that the system always reflects the actual quantity of physical materials as they are consumed and resupplied.
        [HttpPut(Name = "UpdateMaterial/{id}")]
        public IActionResult UpdateMaterial(int id, [FromBody] Material value)
        {
            if (id != value.id)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpDelete(Name = "DeleteMaterial/{id}")]
        public IActionResult DeleteMaterial(int id)
        {
            return Ok();
        }
    }
}
