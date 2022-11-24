using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoSS.Models.ProductModels;
using PoSS.DTOs.ProductDTOs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;

namespace PoSS.Controllers.ProductControllers
{
    [ApiController]
    [Route("{tenantId}/[controller]")]
    public class MaterialController : ControllerBase
    {
        //SHOULD
        //As an inventory manager, I want to manage raw materials that are used to make finished products. 
        /// <summary>
        /// Creates material.
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        /// <response code="400">If some material details are missing.</response>
        [HttpPost]
        public IActionResult CreateMaterial(MaterialDTO material)
        {
            return Ok();
        }

        //As an inventory manager, I want to manage a list of materials that are required to make a certain product so that the consumption of materials could be tracked.
        /// <summary>
        /// Gets material by Id.
        /// </summary>
        /// <param name="materialId"></param>
        /// <returns></returns>
        /// <response code="400">If material with such id does not exist.</response>
        [HttpGet]
        [Route("{materialId}")]
        public IActionResult GetMaterial(int materialId)
        {
            return Ok(new MaterialDTO());
        }

        //As an inventory manager, I want to manage a list of materials that are required to make a certain product so that the consumption of materials could be tracked.
        //? get page of material?
        [HttpGet(Name = "GetMaterials")]
        public IActionResult GetMaterials()
        {
            return Ok();
        }

        //As an inventory manager, I want to update the quantity of materials so that the system always reflects the actual quantity of physical materials as they are consumed and resupplied.
        /// <summary>
        /// Update material by id.
        /// </summary>
        /// <param name="materialId"></param>
        /// <param name="material"></param>
        /// <returns></returns>
        /// <response code="400">If material with such id does not exist.</response>
        /// <response code="400">If some material details are missing.</response>
        [HttpPut]
        [Route("{materialId}")]
        public IActionResult UpdateMaterial(int materialId, MaterialDTO material)
        {
            return Ok();
        }

        /// <summary>
        /// Delete material by id.
        /// </summary>
        /// <param name="materialId"></param>
        /// <returns></returns>
        /// <response code="400">If material with such id does not exist.</response>
        [HttpDelete]
        [Route("{materialId}")]
        public IActionResult DeleteMaterial(int materialId)
        {
            return Ok();
        }
    }
}
