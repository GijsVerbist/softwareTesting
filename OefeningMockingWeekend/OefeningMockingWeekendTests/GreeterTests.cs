using Microsoft.VisualStudio.TestTools.UnitTesting;
using OefeningMockingWeekend;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;
namespace OefeningMockingWeekend.Tests
{
    [TestClass()]
    public class GreeterTests
    {
        

        [TestMethod()]
        public void GetMessageTest()
        {
            DateTime tijd = new DateTime(2020, 10, 18);
            var testest = new Mock<IDateGetter>();
            testest.Setup(x => x.GetDate()).Returns(tijd);

            var something = new Greeter(testest.Object);

            var result = something.GetMessage();
            
            string weekResult = "Work hard, weekend is on his way....";
            string weekendResult = "Party time.....it's weekend";
            Assert.AreEqual(weekendResult, result);
        }
    }
}