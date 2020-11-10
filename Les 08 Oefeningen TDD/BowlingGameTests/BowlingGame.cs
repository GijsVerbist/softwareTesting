namespace BowlingGameScoreTests
{
    internal class BowlingGame
    {
        public int Score { get; private set; }
        public BowlingGame()
        {
        }
        public void Roll(int NumberHit)
        {
            Score += NumberHit;
        }
    }
}