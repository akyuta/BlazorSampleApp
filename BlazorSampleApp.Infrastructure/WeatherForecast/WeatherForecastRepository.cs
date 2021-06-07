using BlazorSampleApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSampleApp.Infrastructure
{
    public class WeatherForecastRepository : IWeatherForecastRepository
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<List<WeatherForecast>> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast(startDate.AddDays(index), rng.Next(-20, 55), Summaries[rng.Next(Summaries.Length)])).ToList());
        }
    }
}
