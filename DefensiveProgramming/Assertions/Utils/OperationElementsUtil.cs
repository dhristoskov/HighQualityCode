using System;
using System.Diagnostics;

namespace Assertions_Homework.Utils
{
    /// <summary>
    /// Util class that contain operation 
    /// over elements in collection
    /// </summary>
    internal static class OperationElementsUtil
    {
        /// <summary>
        /// Search for min element in collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr">collection of elements of type T</param>
        /// <param name="startIndex">starting index from where to start search</param>
        /// <param name="endIndex">end index where the search stops</param>
        /// <returns>min element</returns>
        public static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            //Check for valid collection input
            Debug.Assert(arr != null, "Collection is null!");
            Debug.Assert(arr.Length > 0, "Collection is empty!");

            //Check for valid start and end index
            Debug.Assert(startIndex >= 0 && startIndex < arr.Length, "Value of start index is incorrect!");
            Debug.Assert(endIndex >= 0 && endIndex < arr.Length, "Value of end index is incorrect!");
            Debug.Assert(startIndex + 1 <= endIndex, "start index is greater yhan end index!");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }
            return minElementIndex;
        }

        /// <summary>
        /// Swap two elements
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x">value of type T</param>
        /// <param name="y">value of type T</param>
        public static void Swap<T>(ref T x, ref T y)
        {
            //Check if x or y are null
            Debug.Assert(x != null, "X value is null!");
            Debug.Assert(y != null, "Y value is null!");

            T oldX = x;
            x = y;
            y = oldX;
        }
    }
}
