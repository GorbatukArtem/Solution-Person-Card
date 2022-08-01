using Microsoft.AspNetCore.Mvc;

namespace Client.Content.Controllers
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
        public async Task<IActionResult> Get()
        {
            try
            {
                var home = await Task.FromResult(1);

                _logger.LogInformation("Home was successfully created.");

                return Ok(home);
            }
            catch (Exception)
            {
                _logger.LogError("Home was not successfully created.");
                throw;
            }
        }
    }
}