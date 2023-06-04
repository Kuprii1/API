using Microsoft.AspNetCore.Mvc;
using Прототип_API.Clients;
using Прототип_API.Models;

namespace Прототип_API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PredictionController : Controller
    {
        private readonly ILogger<PredictionController> _logger;

        public PredictionController(ILogger<PredictionController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Prediction")]
        public async Task<List<Prediction>> Prediction(string from, string to, string country_id)
        {
            PredictionClient client = new PredictionClient();
            return await client.PredictionAsync(from,to,country_id);

        }
    }
}
