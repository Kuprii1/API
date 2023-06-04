using Newtonsoft.Json;
using Прототип_API.Models;

namespace Прототип_API.Clients
{
    public class CountriesClient
    {
        private HttpClient _httpClient;
        private static string _address;
        private static string _apikey;
        public CountriesClient()
        {
            _address = Constans.address;
            _apikey = Constans.apikey;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_address);
            _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", _apikey);
        }
        public async Task<Countries> CountriesAsync(string Name)
        {
            var url = $"{Constans.address}/countries?name={Name}";
            var response = await _httpClient.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Countries>(content);
            return result;
        }
    }
}
