using Microsoft.AspNetCore.Mvc;

namespace MyWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetName()
        {
            return Ok(new { name = "Jacob Ziebold" });
        }
    }
}