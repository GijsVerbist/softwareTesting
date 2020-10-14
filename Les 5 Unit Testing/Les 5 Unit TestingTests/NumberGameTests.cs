using Microsoft.VisualStudio.TestTools.UnitTesting;
using Les_5_Unit_Testing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Les_5_Unit_Testing.Tests
{
    [TestClass()]
    public class NumberGameTests
    {
        [TestMethod()]
        public void RateGuess_Returns_2_When_Guess_Is_Correct()
        {
            var numberGame = new NumberGame();

            var result = numberGame.RateGuess(5);

            Assert.AreEqual(2, result);
        }
    }
}