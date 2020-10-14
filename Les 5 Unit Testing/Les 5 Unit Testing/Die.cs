using System;
using System.Collections.Generic;
using System.Text;

namespace Les_5_Unit_Testing
{
    public class Die
    {
        private static readonly Random Random = new Random();

        public int Roll()
        {
            return Random.Next(5) + 1;
        }
    }
}
