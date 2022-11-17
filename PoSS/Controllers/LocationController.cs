using Microsoft.AspNetCore.Mvc;
using PoSS.DTOs;
using PoSS.Models;

namespace PoSS.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class LocationController : CRUDController<Location, LocationDto>
    {
    }
}