using System;
using MathOperations.Tests;

namespace MathOperations
{
    /*
    Math Operation for add, subtract, increment, multiply, divide 
    for int, long, float, double and decimal values.
    +--------------+--------+-------+-------------+--------+---------+
    | n=500        | int    | long  | float       | double | decimal |  
    +--------------+--------+-------+-------------+--------+---------+
    | +            | 0.261  | 0.266 | 0.302       | 0.271  | 0.545   | 
    +--------------+--------+-------+-------------+--------+---------+
    | -            | 0.257  | 0.262 | 0.302       | 0.270  | 0.612   | 
    +--------------+--------+-------+-------------+--------+---------+
    | ++ (postfix) | 0.0039 | 0.039 | 0.044       | 0.044  | 0.601   | 
    +--------------+--------+-------+-------------+--------+---------+
    | *            | 0.319  | 0.328 | 0.854       | 0.778  |    -    |  
    +--------------+--------+-------+-------------+--------+---------+
    | /            | 0.348  | 0.349 | 0.401       | 0.399  | 0.889   |  
    +--------------+--------+-------+-------------+--------+---------+-

    Performance of Math operations  - square root, natural logarithm, 
    sine for float, double and decimal.
    +--------------+-------+--------+---------+
    | n=500        | float | double | decimal |
    +--------------+-------+--------+---------+
    | Math.Sqrt(); | 1.122 | 0.219  | 1.902   |
    +--------------+-------+--------+---------+
    | Math.Log();  | 0.428 | 0.377  | 0.876   |
    +--------------+-------+--------+---------+
    | Math.Sin();  | 0.438 | 0.470  | 0.977   |
    +--------------+-------+--------+---------+
    */
    class MathOperationTest
    {
        static void Main(string[] args)
        {
            //Integer
            IntegerMathPerformance.AddNumber();
            IntegerMathPerformance.SubtractNumber();
            IntegerMathPerformance.IncrementNumber();
            IntegerMathPerformance.MultiplyNumber();
            IntegerMathPerformance.DivideNumber();
            Console.WriteLine();

            //Long
            LongMathPerformance.AddNumber();
            LongMathPerformance.SubtractNumber();
            LongMathPerformance.IncrementNumber();
            LongMathPerformance.MultiplyNumber();
            LongMathPerformance.DivideNumber();
            Console.WriteLine();

            //Float
            FloatMathPerformance.AddNumber();
            FloatMathPerformance.SubtractNumber();
            FloatMathPerformance.IncrementNumber();
            FloatMathPerformance.MultiplyNumber();
            FloatMathPerformance.DivideNumber();
            Console.WriteLine();

            //Double
            DoubleMathPerformance.AddNumber();
            DoubleMathPerformance.SubtractNumber();
            DoubleMathPerformance.IncrementNumber();
            DoubleMathPerformance.MultiplyNumber();
            DoubleMathPerformance.DivideNumber();
            Console.WriteLine();

            //Decimal
            DecimalMathPerformance.AddNumber();
            DecimalMathPerformance.SubtractNumber();
            DecimalMathPerformance.IncrementNumber();
            //DecimalMathPerformance.MultiplyNumber();
            DecimalMathPerformance.DivideNumber();
            Console.WriteLine();

            //Float
            FloatFunctionPerformance.GetMathSqrt();
            FloatFunctionPerformance.GetMathLog();
            FloatFunctionPerformance.GetMathSin();
            Console.WriteLine();

            //Double
            DoubleFunctionPerformance.GetMathSqrt();
            DoubleFunctionPerformance.GetMathLog();
            DoubleFunctionPerformance.GetMathSin();
            Console.WriteLine();

            //Decimal
            DecimalFunctionPerformance.GetMathSqrt();
            DecimalFunctionPerformance.GetMathLog();
            DecimalFunctionPerformance.GetMathSin();
            Console.WriteLine();

        }
    }
}
