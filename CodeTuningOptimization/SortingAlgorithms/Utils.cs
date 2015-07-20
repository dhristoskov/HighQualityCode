using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    static class Utils
    {
        private static readonly Random RandomNumber = new Random();
        public static readonly Stopwatch StopWatch = new Stopwatch();
        public static TimeSpan ElepsedTime = new TimeSpan();
        public static readonly int Capacity = 10;

        /// <summary>
        /// Generated random number collection
        /// </summary>
        /// <param name="capacity">collection capacity</param>
        /// <returns>number<int> collection</returns>
        public static List<int> GenerateRandomNumberCollection(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity has to be a number greater than zero!");
            }

            List<int> randomNumbers = new List<int>(capacity);

            for (int number = 0; number < capacity; number++)
            {
                randomNumbers.Add(RandomNumber.Next(int.MinValue,int.MaxValue));
            }

            return randomNumbers;
        }

        /// <summary>
        /// Check if the collection is sorted
        /// correctly
        /// </summary>
        /// <param name="collection"></param>
        /// <returns>boolean value</returns>
        public static bool AreNumbersSorted(List<int> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection),"Collection ca not be null!");    
            }

            for (int number = 1; number < collection.Count; number++)
            {
                if (collection[number] < collection[number - 1])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Print sorted collection
        /// </summary>
        /// <param name="collection">sorted collection</param>
        public static void PrintSortedCollection(List<int> collection)
        {
            Console.WriteLine(string.Join(", ", collection));
        }
    }
}
