using Newtonsoft.Json;
using Прототип_API.Models;
using Прототип_API;

namespace Прототип_API.Clients
{
    public class PredictionClient
    {
        private HttpClient _httpClient;
        private static string _address;
        private static string _apikey;
        public PredictionClient()
        {
            _address = Constants_predictions.add_ress;
            _apikey = Constants_predictions.api_key;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_address);
        }
        public async Task<List<Prediction>> PredictionAsync(string from, string to, string country_id)
        {
            var responce = await _httpClient.GetAsync($"/?action=get_events&from={from}&to={to}&country_id={country_id}&APIkey={_apikey}");
            responce.EnsureSuccessStatusCode();
            var content = await responce.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Prediction>>(content);
            return result;
        }
    }
}
