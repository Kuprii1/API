using Newtonsoft.Json;
using Прототип_API.Models;

namespace Прототип_API.Clients
{
    public class CoachClient
    {
        private HttpClient _httpClient;
        private static string _address;
        private static string _apikey;
        public CoachClient()
        {
            _address = Constans.address;
            _apikey = Constans.apikey;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_address);
            _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", _apikey);
        }
        public async Task<Coach> CoachAsync(string Name)
        {
            var url = $"{Constans.address}/coachs?search={Name}";
            var response = await _httpClient.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Coach>(content);
            return result;
        }
    }
}
