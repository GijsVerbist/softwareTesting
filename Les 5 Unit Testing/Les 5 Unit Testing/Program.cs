﻿using System;

namespace Les_5_Unit_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberGame = new NumberGame();

            var score = numberGame.RateGuess(5);

            Console.WriteLine($"Uw score is: {score}");
        }
    }
}
