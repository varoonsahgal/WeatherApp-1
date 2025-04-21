using System;
using System.Threading.Tasks;
using WeatherApp.Services; // Ensure this matches the namespace of WeatherService

namespace WeatherApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=====================================");
            Console.WriteLine("      🌤️  Welcome to WeatherApp! 🌧️     ");
            Console.WriteLine("=====================================");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("      .-.      ");
            Console.WriteLine("     (   ).    ");
            Console.WriteLine("    (___(__)   ");
            Console.WriteLine("     ‘ ‘ ‘ ‘   ");
            Console.WriteLine("    ‘ ‘ ‘ ‘    ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=====================================");
            Console.Write("Enter the city name: ");
            Console.ResetColor();

            string city = Console.ReadLine();

            WeatherService weatherService = new WeatherService();
            try
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nFetching weather data...");
                Console.ResetColor();

                var weatherData = await weatherService.GetWeatherAsync(city);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("=====================================");
                Console.WriteLine($"🌍 Weather in {city}: {weatherData}");
                Console.WriteLine("=====================================");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"❌ An error occurred: {ex.Message}");
                Console.ResetColor();
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nThank you for using WeatherApp! 🌈");
            Console.WriteLine("=====================================");
            Console.ResetColor();
        }
    }
}