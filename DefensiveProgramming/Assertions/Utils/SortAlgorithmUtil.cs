using System;
using System.Diagnostics;

namespace Assertions_Homework.Utils
{
    /// <summary>
    /// Class that contain selection sort algorithm
    /// </summary>
    internal static class SortAlgorithmUtil
    {
        /// <summary>
        /// Sorting algorithm for sorting
        /// collections
        /// </summary>
        /// <typeparam name="T">collection of T elements</typeparam>
        /// <param name="arr"></param>
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            //Check for valid collection input
            Debug.Assert(arr != null, "Collection is null!");
            Debug.Assert(arr.Length > 0, "Collection is empty!");

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = OperationElementsUtil.FindMinElementIndex(arr, index, arr.Length - 1);
                OperationElementsUtil.Swap(ref arr[index], ref arr[minElementIndex]);
            }
        }
    }
}
