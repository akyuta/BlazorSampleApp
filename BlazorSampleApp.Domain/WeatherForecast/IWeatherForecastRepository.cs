using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorSampleApp.Domain
{
    public interface IWeatherForecastRepository
    {
        public Task<List<WeatherForecast>> GetForecastAsync(DateTime startDate);
    }
}
