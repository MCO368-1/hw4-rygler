using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTempConverter
{
    public class Utilities
    {
        public static double FahrenheitToCelsius(double temp)
        {
            return (temp - 32) * (5.0 / 9.0);
        }

        public static double CelsiusToFahrenheit(double temp)
        {
            return temp * (9.0 / 5.0) + 32;
        }

        public static double KelvinToCelsius(double temp)
        {
            return temp - 273.15;
        }

        public static double CelsiusToKelvin(double temp)
        {
            return temp + 273.15;
        }

        public static double FahrenheitToKelvin(double temp)
        {
            return (temp + 459.67) * (5.0 / 9.0);
        }

        public static double KelvinToFahrenheit(double temp)
        {
            return temp * (9.0 / 5.0) - 459.67;
        }

        public static double TemperatureToItself(double temp)
        {
            return temp;
        }

        public static double ConvertTemperature(Temperatures temperatureFrom, Temperatures temperatureTo, double temp)
        {
            if (temperatureFrom == temperatureTo)
            {
                return TemperatureToItself(temp);
            }

            switch (temperatureFrom)
            {
                case Temperatures.Kelvin:
                    return temperatureTo == Temperatures.Fahrenheit ? KelvinToFahrenheit(temp) : KelvinToCelsius(temp);
                case Temperatures.Fahrenheit:
                    return temperatureTo == Temperatures.Kelvin ? FahrenheitToKelvin(temp) : FahrenheitToCelsius(temp);
                case Temperatures.Celsius:
                    return temperatureTo == Temperatures.Kelvin ? CelsiusToKelvin(temp) : CelsiusToFahrenheit(temp);
                default:
                    throw new ArgumentOutOfRangeException(nameof(temperatureTo), temperatureTo, null);
            }
        }
    }

    public enum Temperatures
    {
        Fahrenheit = 0,
        Celsius = 1,
        Kelvin = 2
    }
}

