using NUnit.Framework;

namespace BowlingGameScoreTests
{
    public class BowlingGameScoreTests
    {
        private BowlingGame game;
        [SetUp]
        public void Setup()
        {
            game = new BowlingGame();
        }

        private void RollMant(int rools, int pins)
        {
            int counter = 0;
            do
            {
                game.Roll(pins);
                counter++;
            } while (counter <= rools-1);
        }
        [Test]
        public void When_Roll_GlutterGame_Returns_0()
        {

            RollMant(20, 0);

            Assert.AreEqual(0, game.Score);
        }
        [Test]
        public void When_Roll_AllOnes_Returns_20()
        {

            RollMant(20, 1);

            Assert.AreEqual(20, game.Score);
        }
    }
}