using Newtonsoft.Json;
using Прототип_API.Models;

namespace Прототип_API.Clients
{
    public class VenuesClient
    {
        private HttpClient _httpClient;
        private static string _address;
        private static string _apikey;
        public VenuesClient()
        {
            _address = Constans.address;
            _apikey = Constans.apikey;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_address);
            _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", _apikey);
        }

        public async Task<Venues> VenuesStatisticsAsync(string Name)
        {
            var url = $"{Constans.address}/venues?city={Name}";
            var response = await _httpClient.GetAsync(url);

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Venues>(content);
            return result;

        }
    }
}
