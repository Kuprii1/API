using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Прототип_API.Clients;
using Прототип_API.Models;

namespace Прототип_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VenuesController : Controller
    {
        private readonly ILogger<VenuesController> _logger;

        public VenuesController(ILogger<VenuesController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Venues")]
        public async Task<Venues> Teams(string Name)
        {
            VenuesClient client = new VenuesClient();
            return await client.VenuesStatisticsAsync(Name);
        }
    }
}
