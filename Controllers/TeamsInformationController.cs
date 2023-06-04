using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Прототип_API.Clients;
using Прототип_API.Models;

namespace Прототип_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamsInformationController : Controller
    {
        private readonly ILogger<TeamsInformationController> _logger;

        public TeamsInformationController(ILogger<TeamsInformationController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "TeamsInformation")]
        public async Task<TeamsInformation> TeamsInformation(string Name)
        {
            TeamsInformationClient client = new TeamsInformationClient();
            return await client.TeamsInformationsAsync(Name);

        }
    }
}