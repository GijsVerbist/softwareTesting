using NUnit.Framework;

namespace BowlingGameScoreTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void When_Roll_GlutterGame_Returns_0()
        {
            var bowlingGame = new BowlingGame();
            int counter = 0;
            do
            {
                bowlingGame.Roll(0);
                counter++;
            } while (counter <= 20);

            Assert.AreEqual(0, bowlingGame.Score);
        }
    }
}