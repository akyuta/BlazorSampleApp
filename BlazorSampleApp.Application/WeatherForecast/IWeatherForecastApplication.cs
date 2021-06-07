using BlazorSampleApp.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorSampleApp.Application
{
    public interface IWeatherForecastApplication
    {
        public Task<List<WeatherForecast>> GetForecastAsync(DateTime startDate);
    }
}
