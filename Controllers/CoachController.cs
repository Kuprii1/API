using Microsoft.AspNetCore.Mvc;
using Прототип_API.Clients;
using Прототип_API.Models;

namespace Прототип_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoachController : Controller
    {
        private readonly ILogger<CoachController> _logger;

        public CoachController(ILogger<CoachController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Coach")]
        public async Task<Coach> Coach(string Name)
        {
            CoachClient client = new CoachClient();
            return await client.CoachAsync(Name);

        }
    }
}
