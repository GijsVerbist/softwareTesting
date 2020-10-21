using System;

namespace OefeningMockingOpenWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            var openWeatherMapApi = new OpenWeatherMapApi();
            var temp = openWeatherMapApi.GetCurrentTemperatureInAntwerp();

            Console.WriteLine(temp);
            
        }
    }
}
