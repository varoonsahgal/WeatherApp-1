using System;
using System.Threading.Tasks;
using WeatherApp.Services; // Ensure this matches the namespace of WeatherService

namespace WeatherApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("      Welcome to WeatherApp!         ");
            Console.WriteLine("=====================================");
            Console.WriteLine("      .-.      ");
            Console.WriteLine("     (   ).    ");
            Console.WriteLine("    (___(__)   ");
            Console.WriteLine("     ‘ ‘ ‘ ‘   ");
            Console.WriteLine("    ‘ ‘ ‘ ‘    ");
            Console.WriteLine("=====================================");

            Console.Write("Enter the city name: ");
            string city = Console.ReadLine();

            WeatherService weatherService = new WeatherService();
            try
            {
                var weatherData = await weatherService.GetWeatherAsync(city);
                Console.WriteLine("=====================================");
                Console.WriteLine($"Weather in {city}: {weatherData}");
                Console.WriteLine("=====================================");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}