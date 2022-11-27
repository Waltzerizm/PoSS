using Microsoft.AspNetCore.Mvc;
using PoSS.DTOs;
using PoSS.Models;

namespace PoSS.Controllers
{
    /// <summary>
    /// Controller for managing services.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ServiceController : CRUDController<Service, ServiceDto>
    {
    }
}