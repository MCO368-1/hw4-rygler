using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WindowsFormsTempConverter.Test
{
    public class UtilitiesTest
    {
        private const double Tolerance = 0.00001;

        [Test]
        public void ConvertTemperature()
        {
            Assert.IsTrue(Math.Abs(Utilities.ConvertTemperature(Temperatures.Celsius, Temperatures.Fahrenheit, 50) - 122) < Tolerance);
            Assert.IsTrue(Math.Abs(Utilities.ConvertTemperature(Temperatures.Celsius, Temperatures.Kelvin, -223.15) - 50) < Tolerance);
            Assert.IsTrue(Math.Abs(Utilities.ConvertTemperature(Temperatures.Celsius, Temperatures.Celsius, 50) - 50) < Tolerance);

            Assert.IsTrue(Math.Abs(Utilities.ConvertTemperature(Temperatures.Fahrenheit, Temperatures.Celsius, 122) - 50) < Tolerance);
            Assert.IsTrue(Math.Abs(Utilities.ConvertTemperature(Temperatures.Fahrenheit, Temperatures.Kelvin, -369.67) - 50) < Tolerance);
            Assert.IsTrue(Math.Abs(Utilities.ConvertTemperature(Temperatures.Fahrenheit, Temperatures.Fahrenheit, 50) - 50) < Tolerance);

            Assert.IsTrue(Math.Abs(Utilities.ConvertTemperature(Temperatures.Kelvin, Temperatures.Celsius, 50) - -223.15) < Tolerance);
            Assert.IsTrue(Math.Abs(Utilities.ConvertTemperature(Temperatures.Kelvin, Temperatures.Fahrenheit, 50) - -369.67) < Tolerance);
            Assert.IsTrue(Math.Abs(Utilities.ConvertTemperature(Temperatures.Kelvin, Temperatures.Kelvin, 50) - 50) < Tolerance);
        }

        [Test]
        public void CelsiusToFahrenheit()
        {
            Assert.IsTrue(Math.Abs(Utilities.CelsiusToFahrenheit(50) - 122) < Tolerance);
        }

        [Test]
        public void FahrenheitToCelsius()
        {
            Assert.IsTrue(Math.Abs(Utilities.FahrenheitToCelsius(122) - 50) < Tolerance);
        }

        [Test]
        public void KelvinToCelsius()
        {
            Assert.IsTrue(Math.Abs(Utilities.KelvinToCelsius(50) - (-223.15)) < Tolerance);
        }

        [Test]
        public void CelsiusToKelvin()
        {
            Assert.IsTrue(Math.Abs(Utilities.CelsiusToKelvin(-223.15) - 50) < Tolerance);
        }

        [Test]
        public void FahrenheitToKelvin()
        {
            Assert.IsTrue(Math.Abs(Utilities.FahrenheitToKelvin(-369.67) - 50) < Tolerance);
        }

        [Test]
        public void KelvinToFahrenheit()
        {
            Assert.IsTrue(Math.Abs(Utilities.KelvinToFahrenheit(50) - (-369.67)) < Tolerance);
        }
    }
}
