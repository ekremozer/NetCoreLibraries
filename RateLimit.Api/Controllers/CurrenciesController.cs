using Microsoft.AspNetCore.Mvc;

namespace RateLimit.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CurrenciesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Usd()
        {
            return Ok(new { USD = 18 });
        }

        [HttpGet]
        public IActionResult Eur()
        {
            return Ok(new { EUR = 19 });
        }

        [HttpGet]
        public IActionResult GetDateTime()
        {
            return Ok(new { DateTime = DateTime.Now });
        }
    }
}
