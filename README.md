# WeatherApp

This is a simple console application that retrieves and displays weather information for a specified city.

## Project Structure

- **WeatherApp.sln**: Solution file that organizes the project and its components.
- **Program.cs**: Entry point of the application. Prompts for a city name and displays the weather information.
- **Services/WeatherService.cs**: Contains the `WeatherService` class for fetching weather data from an external API.
- **Models/WeatherData.cs**: Defines the `WeatherData` class representing the structure of the weather data.
- **appsettings.json**: Configuration file for API keys and endpoint URLs.

## Getting Started

1. Clone the repository or download the project files.
2. Open the solution in your preferred C# development environment.
3. Ensure you have the necessary API keys and update the `appsettings.json` file accordingly.
4. Build the project.
5. Run the application and enter a city name when prompted to retrieve the weather information.

## Dependencies

- .NET SDK (version required)
- Any additional libraries used for making HTTP requests (e.g., HttpClient)

## License

This project is licensed under the MIT License. See the LICENSE file for details.