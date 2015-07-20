using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations.Tests
{
    class FloatMathPerformance
    {
        //Float Add performance time 
        public static void AddNumber()
        {
            float testFloat = 0;
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testFloat += Util.GetRandomNumber();
                }
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Float add operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }

        //Float Subtract performance time
        public static void SubtractNumber()
        {
            float testFloat = Util.GetRandomNumber();
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testFloat -= Util.GetRandomNumber();
                }
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Float subtract operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }

        //Float Increment performance time
        public static void IncrementNumber()
        {
            float testFloat = 0;
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                testFloat++;
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Float subtract operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }

        //Float Muliply performance time
        public static void MultiplyNumber()
        {
            float testFloat = 1;
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testFloat *= Util.GetRandomNumber();
                }
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Float muliply operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }

        //Float Divide performance time
        public static void DivideNumber()
        {
            float testFloat = Util.GetRandomNumber();
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testFloat /= Util.GetRandomNumber();
                }
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Float divide operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }
    }
}
