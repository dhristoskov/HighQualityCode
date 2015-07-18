using System;
using System.Linq;

namespace HighQualityMethods.Utils
{
    static class NumberUtil
    {
        private static readonly string[] DigitsAsNames =
        {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"
        };

        /// <summary>
        /// Return digit name if it is in range
        /// 0 - 9, otherwise throw an exception
        /// </summary>
        /// <param name="digit"></param>
        /// <returns></returns>
        public static string GetDigitName(int digit)
        {
            if (digit < 0 || digit > 9)
            {
                throw new ArgumentOutOfRangeException(nameof(digit),"Digit must be in range 0-9!");
            }

            string digitName = DigitsAsNames[digit];
            return digitName;
        }

        /// <summary>
        /// Find max element in collection
        /// of numbers(integers)
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        public static int FindMaxNumber(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException(nameof(elements), "Collection can be null!");
            }

            if (elements.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(elements), "Collections does not contain elements!");
            }

            int maxElement = elements.Max();        
            return maxElement;
        }

        public static void PrintNumberAsPercent(dynamic number)
        {
            Console.WriteLine("{0:P2}", number);
        }

        public static void PrintNumberWithFixedPoint(dynamic number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        public static void PrintNumberRightAlignment(dynamic number)
        {
            Console.WriteLine("{0,8}", number);
        }     
    }
}
