using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    static class Util
    {
        private static readonly Random RandomNumber = new Random();
        public static readonly Stopwatch StopWatch = new Stopwatch();
        public const int Count = 500;
        
        public static int GetRandomNumber()
        {
            return RandomNumber.Next(1, 1500);
        }

        public static double GetRandomDouble()
        {
            var randomDouble = RandomNumber.NextDouble() * RandomNumber.Next(1, 1500);
            return randomDouble;
        }
    }
}
