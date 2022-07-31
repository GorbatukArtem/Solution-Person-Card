using Logic.Content.Interfaces;
using Logic.Content.Models;
using Microsoft.AspNetCore.Mvc;

namespace Client.Angular.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IServiceHome serviceHome;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IServiceHome serviceHome, ILogger<HomeController> logger)
        {
            this.serviceHome = serviceHome;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var home = await serviceHome.GetAsync();

                _logger.LogInformation("Home was successfully created.");

                return Ok(home);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}