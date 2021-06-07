using BlazorSampleApp.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorSampleApp.Application
{
    public class WeatherForecastApplication : IWeatherForecastApplication
    {
        private readonly IWeatherForecastRepository _weatherForecastRepository;

        public WeatherForecastApplication(IWeatherForecastRepository weatherForecastRepository)
        {
            _weatherForecastRepository = weatherForecastRepository;
        }

        public async Task<List<WeatherForecast>> GetForecastAsync(DateTime startDate)
        {
            return await _weatherForecastRepository.GetForecastAsync(startDate);
        }
    }
}
