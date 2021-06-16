using System;

namespace BlazorSampleApp.Domain
{
    public class Celsius
    {
        public double Value { get; }

        private const double AbsoluteZero = -273.15;

        public Celsius(double value)
        {
            if (value < AbsoluteZero) throw new ArgumentOutOfRangeException();

            Value = value;
        }
    }
}
