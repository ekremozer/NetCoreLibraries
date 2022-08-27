using Microsoft.AspNetCore.Mvc;

namespace RateLimit.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class MinesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Gold()
        {
            return Ok(new { Gold = 1200 });
        }

        [HttpGet]
        public IActionResult Silver()
        {
            return Ok(new { Silver = 400 });
        }
    }
}
