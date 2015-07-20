using System;

namespace MathOperations.Tests
{
    class IntegerMathPerformance
    {
        //Integer Add performance time 
        public static void AddNumber()
        {
            int testInteger = 0;
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testInteger += Util.GetRandomNumber();
                }                
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Integer add operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }

        //Integer Subtract performance time
        public static void SubtractNumber()
        {
            int testInteger = Util.GetRandomNumber();
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testInteger -= Util.GetRandomNumber();
                }
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Integer subtract operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }

        //Integer Increment performance time
        public static void IncrementNumber()
        {
            int testInteger = 0;
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                testInteger++;
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Integer subtract operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }

        //Integer Muliply performance time
        public static void MultiplyNumber()
        {
            int testInteger = 1;
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testInteger *= Util.GetRandomNumber();
                }                
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Integer muliply operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }

        //Integer Divide performance time
        public static void DivideNumber()
        {
            int testInteger = Util.GetRandomNumber();
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testInteger /= Util.GetRandomNumber();
                }
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Integer divide operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }
    }
}
