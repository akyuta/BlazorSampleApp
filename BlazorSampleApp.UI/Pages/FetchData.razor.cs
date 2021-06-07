using BlazorSampleApp.Application;
using BlazorSampleApp.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSampleApp.UI.Pages
{
    public partial class FetchData : ComponentBase
    {
        private List<WeatherForecast> forecastList = new() { };

        [Inject] private IWeatherForecastApplication WeatherForecastApplication { get; set; }

        protected override async Task OnInitializedAsync()
        {
            forecastList = await WeatherForecastApplication.GetForecastAsync(DateTime.Now);
        }
    }
}
