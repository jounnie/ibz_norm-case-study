using System;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Cities = new[]
        {
            "Tokyo", "Zurich", "Basel", "Munich", "Berlin", "Rome", "Paris", "Amsterdam", "London", "New York"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 15).Select(index => new WeatherForecast
            {
                DepDate = startDate.AddDays(index),
                Arrival = startDate.AddDays(index),
                Departure = Cities[rng.Next(Cities.Length)],
                Destination = Cities[rng.Next(Cities.Length)]
            }).ToArray());
        }
    }
}
