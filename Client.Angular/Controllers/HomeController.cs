using Microsoft.AspNetCore.Mvc;

namespace Client.Angular.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return Enumerable.Empty<string>();
        }
    }
}