using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherApp.Services
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;

        public WeatherService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<WeatherData> GetWeatherAsync(string city)
        {
            string apiKey = "YOUR_API_KEY"; // Replace with your actual API key
            string url = $"https://api.weatherapi.com/v1/current.json?key={apiKey}&q={city}";

            var response = await _httpClient.GetStringAsync(url);
            var weatherData = JsonConvert.DeserializeObject<WeatherData>(response);

            return weatherData;
        }
    }
}