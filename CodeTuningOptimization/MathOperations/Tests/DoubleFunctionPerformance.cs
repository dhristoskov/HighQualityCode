using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations.Tests
{
    class DoubleFunctionPerformance
    {
        //Double Math Sqrt performance time
        public static void GetMathSqrt()
        {
            double testDouble = 0;
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testDouble = (double)Math.Sqrt(Util.GetRandomDouble());
                }
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Double Math Sqrt operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }

        //Double Math Log performance time
        public static void GetMathLog()
        {
            double testDouble = 0;
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testDouble = (double)Math.Log(Util.GetRandomDouble());
                }
            }
            Util.StopWatch.Stop();
            Console.WriteLine("Double Math Log operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }

        //Double Math Sin performance time
        public static void GetMathSin()
        {
            double testDouble = 0;
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testDouble = (double)Math.Sin(Util.GetRandomDouble());
                }
            }
            Util.StopWatch.Stop();
            Console.WriteLine("Double Math Sin operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }
    }
}
