using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations.Tests
{
    class DoubleMathPerformance
    {
        //Double Add performance time 
        public static void AddNumber()
        {
            double testDouble = 0;
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testDouble += Util.GetRandomNumber();
                }
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Double add operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }

        //Double Subtract performance time
        public static void SubtractNumber()
        {
            double testDouble = Util.GetRandomNumber();
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testDouble -= Util.GetRandomNumber();
                }
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Double subtract operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }

        //Double Increment performance time
        public static void IncrementNumber()
        {
            double testDouble = 0;
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                testDouble++;
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Double subtract operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }

        //Double Muliply performance time
        public static void MultiplyNumber()
        {
            double testDouble = 1;
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testDouble *= Util.GetRandomNumber();
                }
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Double muliply operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }

        //Double Divide performance time
        public static void DivideNumber()
        {
            double testDouble = Util.GetRandomNumber();
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testDouble /= Util.GetRandomNumber();
                }
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Double divide operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }
    }
}
