using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations.Tests
{
    class FloatFunctionPerformance
    {
        //Float Math Sqrt performance time
        public static void GetMathSqrt()
        {
            float testFloat = 0;
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testFloat = (float)Math.Sqrt(Util.GetRandomDouble());
                }
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Float Math Sqrt operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }

        //Float Math Log performance time
        public static void GetMathLog()
        {
            float testFloat = 0;
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testFloat = (float)Math.Log(Util.GetRandomDouble());
                }
            }
            Util.StopWatch.Stop();
            Console.WriteLine("Float Math Log operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }

        //Float Math Sin performance time
        public static void GetMathSin()
        {
            float testFloat = 0;
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testFloat = (float)Math.Sin(Util.GetRandomDouble());
                }
            }
            Util.StopWatch.Stop();
            Console.WriteLine("Float Math Sin operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }
    }
}
