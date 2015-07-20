using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations.Tests
{
    class LongMathPerformance
    {
        //Long Add performance time 
        public static void AddNumber()
        {
            long testLong = 0;
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testLong += Util.GetRandomNumber();
                }
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Long add operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }

        //Long Subtract performance time
        public static void SubtractNumber()
        {
            long testLong = Util.GetRandomNumber();
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testLong -= Util.GetRandomNumber();
                }
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Long subtract operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }

        //Long Increment performance time
        public static void IncrementNumber()
        {
            long testLong = 0;
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                testLong++;
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Long subtract operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }

        //Long Muliply performance time
        public static void MultiplyNumber()
        {
            long testLong = 1;
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testLong *= Util.GetRandomNumber();
                }
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Long muliply operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }

        //Long Divide performance time
        public static void DivideNumber()
        {
            long testLong = Util.GetRandomNumber();
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testLong /= Util.GetRandomNumber();
                }
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Long divide operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }
    }
}
