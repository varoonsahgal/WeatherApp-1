using System;
using System.Threading.Tasks;
using WeatherApp.Services; // Ensure this matches the namespace of WeatherService

namespace WeatherApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Write("Enter the city name: ");
            string city = Console.ReadLine();

            WeatherService weatherService = new WeatherService();
            try
            {
                var weatherData = await weatherService.GetWeatherAsync(city);
                Console.WriteLine($"Weather in {city}: {weatherData}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}