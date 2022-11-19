using Microsoft.AspNetCore.Mvc;

namespace PoSS.Controllers
{
    public class CRUDController<T, TDto> : ControllerBase
    {
        [HttpGet]
        public ActionResult<TDto> Get()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult<TDto> Get(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] TDto dto)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TDto dto)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
       
    }
}