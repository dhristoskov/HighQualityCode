using System;
using Assertions_Homework.Utils;

namespace Assertions_Homework
{
    class AssertionsTest
    {        
        static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            SortAlgorithmUtil.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            SortAlgorithmUtil.SelectionSort(new int[0]); // Test sorting empty array
            SortAlgorithmUtil.SelectionSort(new int[1]); // Test sorting single element array

            Console.WriteLine(SearchAlgorithmUtil.BinarySearch(arr, -1000));
            Console.WriteLine(SearchAlgorithmUtil.BinarySearch(arr, 0));
            Console.WriteLine(SearchAlgorithmUtil.BinarySearch(arr, 17));
            Console.WriteLine(SearchAlgorithmUtil.BinarySearch(arr, 10));
            Console.WriteLine(SearchAlgorithmUtil.BinarySearch(arr, 1000));
        }
    }
}
