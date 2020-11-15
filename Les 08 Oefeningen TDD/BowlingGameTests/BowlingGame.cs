using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGameScore
{
    public class BowlingGame
    {
        private int[] pins = new int[20];  // het aantal omgeworpen kegels per worp (maximaal 21 worpen laatste frame een spare + 1 of strike + 2;
        private int currentRoll = 0;       // teller van het aantal worpen die de gebruiker heeft gedaan

        public int Score
        {
            get
            {
                int score = 0;
                int rollIndex = 0;
                for (int frame = 0; frame < 10; frame++) // loop over het aantal worpen
                {
                    if(pins[rollIndex] + pins[rollIndex + 1] == 10)
                    {
                        score += pins[rollIndex] + pins[rollIndex + 1] + pins[rollIndex + 2];
                    }
                    else
                    {
                        score += pins[rollIndex] + pins[rollIndex + 1];
                    }
                    
                    rollIndex += 2;
                }

                return score;
            }
        }
        public void Roll(int pinsThisRoll)
        {
            pins[currentRoll++] = pinsThisRoll;
        }
    }
}