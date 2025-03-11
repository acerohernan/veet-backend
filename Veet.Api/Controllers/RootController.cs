using Microsoft.AspNetCore.Mvc;

namespace Veet.Api.Controllers
{
    [ApiController]
    [Route("/")]
    public class RootController : ControllerBase
    {
        [HttpGet("/status")]
        public IActionResult GetStatus()
        {
            return Ok("OK");
        }
    }
}
