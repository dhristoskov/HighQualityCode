using System;
using System.Diagnostics;

namespace Assertions_Homework.Utils
{
    internal static class SearchAlgorithmUtil
    {
        internal static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            //Check for valid collection input
            Debug.Assert(arr != null, "Collection is null!");
            Debug.Assert(arr.Length > 0, "Collection is empty!");

            //Check for valid T value input
            Debug.Assert(value != null, "Searching value is null.");

            //Check for valid start and end index
            Debug.Assert(startIndex >= 0 && startIndex < arr.Length, "Invalid startIndex value.");
            Debug.Assert(endIndex >= 0 && endIndex < arr.Length, "Invalid endIndex value.");
            Debug.Assert(startIndex <= endIndex, "start index is greater yhan end index!");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex)/2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }
                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }
            // Searched value not found
            return -1;
        }
    }
}
