using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations.Tests
{
    class DecimalMathPerformance
    {
        //Decimal Add performance time 
        public static void AddNumber()
        {
            decimal testDecimal = 0;
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testDecimal += Util.GetRandomNumber();
                }
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Decimal add operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }

        //Decimal Subtract performance time
        public static void SubtractNumber()
        {
            decimal testDecimal = Util.GetRandomNumber();
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testDecimal -= Util.GetRandomNumber();
                }
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Decimal subtract operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }

        //Decimal Increment performance time
        public static void IncrementNumber()
        {
            decimal testDecimal = 0;
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                testDecimal++;
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Decimal subtract operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }

        //Decimal Muliply performance time
        public static void MultiplyNumber()
        {
            decimal testDecimal = 1m;
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testDecimal *= Util.GetRandomNumber();
                }
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Decimal muliply operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }

        //Decimal Divide performance time
        public static void DivideNumber()
        {
            decimal testDecimal = Util.GetRandomNumber();
            Util.StopWatch.Start();
            for (int number = 0; number < Util.Count; number++)
            {
                unchecked
                {
                    testDecimal /= Util.GetRandomNumber();
                }
            }

            Util.StopWatch.Stop();
            Console.WriteLine("Decimal divide operation time is {0}", Util.StopWatch.Elapsed);
            Util.StopWatch.Reset();
        }
    }
}
