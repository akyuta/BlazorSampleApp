namespace BlazorSampleApp.Domain
{
    public interface ITemperatureService
    {
        public Fahrenheit ConvertIntoFahrenheit(Celsius celsius);
    }
}
