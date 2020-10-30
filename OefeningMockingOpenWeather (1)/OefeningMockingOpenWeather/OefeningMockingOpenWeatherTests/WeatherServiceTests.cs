using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;
namespace OefeningMockingOpenWeather.Tests
{
    [TestClass()]
    public class WeatherServiceTests
    {
        [TestMethod()]
        public void Freezing_Weather()
        {
            var test = new Mock<IOpenWeatherMapApi>();
            test.Setup(x => x.GetCurrentTemperatureInAntwerp()).Returns(-1);
            var weatherService = new WeatherService(test.Object);
            var result = weatherService.GetCurrentWeatherInAntwerp();
            Assert.AreEqual("Brrrr, it's freezing", result);

        }
        [TestMethod()]
        public void Cold_Weather()
        {
            var test = new Mock<IOpenWeatherMapApi>();
            test.Setup(x => x.GetCurrentTemperatureInAntwerp()).Returns(14);
            var weatherService = new WeatherService(test.Object);
            var result = weatherService.GetCurrentWeatherInAntwerp();
            Assert.AreEqual("It's cold", result);

        }
        [TestMethod()]
        public void Ok_Weather()
        {
            var test = new Mock<IOpenWeatherMapApi>();
            test.Setup(x => x.GetCurrentTemperatureInAntwerp()).Returns(16);
            var weatherService = new WeatherService(test.Object);
            var result = weatherService.GetCurrentWeatherInAntwerp();
            Assert.AreEqual("it's ok", result);

        }
        [TestMethod()]
        public void Hot_Weather()
        {
            var test = new Mock<IOpenWeatherMapApi>();
            test.Setup(x => x.GetCurrentTemperatureInAntwerp()).Returns(30);
            var weatherService = new WeatherService(test.Object);
            var result = weatherService.GetCurrentWeatherInAntwerp();
            Assert.AreEqual("It's HOT!!!", result);

        }
    }
}