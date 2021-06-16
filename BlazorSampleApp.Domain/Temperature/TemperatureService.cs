using System;

namespace BlazorSampleApp.Domain
{
    public class TemperatureService : ITemperatureService
    {
        public Fahrenheit ConvertIntoFahrenheit(Celsius celsius)
        {
            if (celsius == null) throw new ArgumentNullException();

            double value = 32 + (celsius.Value * 9 / 5);

            return new Fahrenheit(value);
        }
    }
}
