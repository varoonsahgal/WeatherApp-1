using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WeatherApp.Services
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;

        public WeatherService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> GetWeatherAsync(string city)
        {
            string url = $"https://wttr.in/{city}?format=%C+%t"; // Fetch weather condition and temperature

            try
            {
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Throws an exception if the status code is not 2xx

                var weatherData = await response.Content.ReadAsStringAsync();
                return weatherData;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error fetching weather data: {ex.Message}");
                throw; // Re-throw the exception to allow further handling if needed
            }
        }
    }
}