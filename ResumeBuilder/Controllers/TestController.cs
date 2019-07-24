using Microsoft.AspNetCore.Mvc;

namespace ResumeBuilder.Controllers
{
    [Route("api/test")]
    [ApiController]
    public class TestController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("The API works!");
        }
    }
}