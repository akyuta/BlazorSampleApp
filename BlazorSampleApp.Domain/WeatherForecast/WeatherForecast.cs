using System;

namespace BlazorSampleApp.Domain
{
    public class WeatherForecast
    {
        public DateTime Date { get; }
        public Celsius TemperatureC { get; }
        public Fahrenheit TemperatureF
        {
            get => temperatureService.ConvertIntoFahrenheit(TemperatureC);
        }
        public string Summary { get; }

        private readonly ITemperatureService temperatureService = new TemperatureService();

        public WeatherForecast(DateTime date, Celsius temperatureC, string summary)
        {
            if (date == default) throw new ArgumentException();
            if (temperatureC == null) throw new ArgumentNullException();

            Date = date;
            TemperatureC = temperatureC;
            Summary = summary;
        }
    }
}