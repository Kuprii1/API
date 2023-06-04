using Microsoft.AspNetCore.Mvc;
using Прототип_API.Clients;
using Прототип_API.Models;

namespace Прототип_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountriesController : Controller
    {
        private readonly ILogger<CountriesController> _logger;

        public CountriesController(ILogger<CountriesController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Countries")]
        public async Task<Countries> Coach(string Name)
        {
            CountriesClient client = new CountriesClient();
            return await client.CountriesAsync(Name);

        }
    }
}
