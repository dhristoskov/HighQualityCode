using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations.Tests
{
    class DecimalFunctionPerformance
    {
        //Decimal Math Sqrt performance time
        public static void GetMathSqrt()
        {
            decimal testDecimal = 0;
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testDecimal = (decimal)Math.Sqrt(Util.GetRandomDouble());
                }
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Decimal Math Sqrt operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }

        //Decimal Math Log performance time
        public static void GetMathLog()
        {
            decimal testDecimal = 0;
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testDecimal = (decimal)Math.Log(Util.GetRandomDouble());
                }
            }
            Util.StopWatch.Stop();
            Console.WriteLine("Decimal Math Log operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }

        //Decimal Math Sin performance time
        public static void GetMathSin()
        {
            decimal testDecimal = 0;
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testDecimal = (decimal)Math.Sin(Util.GetRandomDouble());
                }
            }
            Util.StopWatch.Stop();
            Console.WriteLine("Decimal Math Sin operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }
    }
}
