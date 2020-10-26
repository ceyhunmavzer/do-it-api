using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BonjourController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Bonjour!");
        }
    }
}