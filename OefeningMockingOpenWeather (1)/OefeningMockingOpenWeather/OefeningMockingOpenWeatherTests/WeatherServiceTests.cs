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
        public void GetCurrentWeatherInAntwerpTest()
        {
            var test = new Mock<IOpenWeatherMapApi>();
            test.Setup(x => x.GetCurrentTemperatureInAntwerp()).Returns(16);
            var weatherService = new WeatherService(test.Object);
            var result = weatherService.GetCurrentWeatherInAntwerp();
            var truth = "it's ok";
            Assert.AreEqual(truth, result);

        }
    }
}