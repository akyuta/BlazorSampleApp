using System;

namespace BlazorSampleApp.Domain
{
    public class Fahrenheit
    {
        public double Value { get; }

        private const double AbsoluteZero = -459.67;

        public Fahrenheit(double value)
        {
            if (value < AbsoluteZero) throw new ArgumentOutOfRangeException();

            Value = value;
        }
    }
}
