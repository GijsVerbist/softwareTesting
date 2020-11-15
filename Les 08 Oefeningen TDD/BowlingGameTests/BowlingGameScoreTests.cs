using BowlingGameScore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
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

        private void RollMant(int pins, int rools)
        {
            for (var i = 0; i < rools; i++)
            {
                game.Roll(pins);
            }
        }
        [Test]
        public void When_Roll_GlutterGame_Returns_0()
        {

            RollMant(0, 20);

            Assert.AreEqual(0, game.Score);
        }
        [Test]
        public void When_Roll_AllOnes_Returns_20()
        {

            RollMant(1, 20);

            Assert.AreEqual(20, game.Score);
        }
        [Test]
        public void When_Roll_SpareAndThree_Returns_16()
        {

            game.Roll(5);
            game.Roll(5);
            game.Roll(3);
            RollMant(0, 17);

            Assert.AreEqual(16, game.Score);
        }
        [Test]
        public void When_Roll_Strike()
        {
            game.Roll(10);
            game.Roll(3);
            game.Roll(4);
            RollMant(0, 16);
            Assert.AreEqual(24, game.Score);
        }
        [Test]
        public void PerfectGame()
        {
            RollMant(10, 12);
            Assert.AreEqual(300, game.Score);
        }
    }
}