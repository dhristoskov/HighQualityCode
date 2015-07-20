using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithms.SortingAlgorithms;

namespace SortingAlgorithms
{
    /*  +===========+========+========+=========+========+=========+==========+===========+============+
        |  Method   | n=10   | n=50   | n=100   | n=1000 | n=10000 | n=100000 | n=1000000 | n=10000000 |
        +===========+========+========+=========+========+=========+==========+===========+============+
        | Insertion |   45   |  118   |   390   | 24619  | 2554383 |   23sec. |  hangs    |    hangs   |
        +-----------+--------+--------+---------+--------+---------+----------+-----------+------------+
        | Selection |   29   |  192   |    639  | 55700  | 5430771 |   59sec. |  hangs    |   hangs    |
        +-----------+--------+--------+---------+--------+---------+----------+-----------+------------+
        | Quick     |   68   |  1100  |   7989  | 2000727|  48sec. |  hangs   |   hangs   |   hangs    |
        +-----------+--------+--------+---------+--------+---------+----------+-----------+------------+
        | Marge     |   22   |  62    |   172   |  1700  |  18987  |  255321  |  3000121  |    3sec.   |
        +-----------+--------+--------+---------+--------+---------+----------+-----------+------------+
    */

    class Program
    {
        static void Main(string[] args)
        {
            List<int> unsortedCollection = new List<int>();
            List<int> sortedCollection = new List<int>();

            unsortedCollection = Utils.GenerateRandomNumberCollection(Utils.Capacity);
            sortedCollection = InsertionSort.InsertionSortAlgorithm(unsortedCollection);
            Console.WriteLine("Collection sorted with Insertion Sort: {0}", Utils.AreNumbersSorted(sortedCollection) ? "Is sorted" : "Is not sorted");
            Console.WriteLine("Insertion Sort performance time is {0}", Utils.ElepsedTime);
            //Utils.PrintSortedCollection(sortedCollection);
            Utils.StopWatch.Reset();

            unsortedCollection = Utils.GenerateRandomNumberCollection(Utils.Capacity);
            sortedCollection = SelectionSort.SelectionSortAlgorithm(unsortedCollection);
            Console.WriteLine("Collection sorted with Selection Sort: {0}", Utils.AreNumbersSorted(sortedCollection) ? "Is sorted" : "Is not sorted");
            Console.WriteLine("Selection Sort performance time is {0}", Utils.ElepsedTime);
            //Utils.PrintSortedCollection(sortedCollection);
            Utils.StopWatch.Reset();

            unsortedCollection = Utils.GenerateRandomNumberCollection(Utils.Capacity);
            sortedCollection = QuickSort.QuickSortAlgorithm(unsortedCollection, 0, unsortedCollection.Count - 1);
            Console.WriteLine("Collection sorted with Quick Sort: {0}", Utils.AreNumbersSorted(sortedCollection) ? "Is sorted" : "Is not sorted");
            Console.WriteLine("Quick Sort performance time is {0}", Utils.ElepsedTime);
            //Utils.PrintSortedCollection(sortedCollection);
            Utils.StopWatch.Reset();

            unsortedCollection = Utils.GenerateRandomNumberCollection(Utils.Capacity);
            sortedCollection = MergeSort.MergeSortAlgorithm(unsortedCollection, 0, unsortedCollection.Count - 1);
            Console.WriteLine("Collection sorted with Merge Sort: {0}", Utils.AreNumbersSorted(sortedCollection) ? "Is sorted" : "Is not sorted");
            Console.WriteLine("Merge Sort performance time is {0}", Utils.ElepsedTime);
            //Utils.PrintSortedCollection(sortedCollection);
            Utils.StopWatch.Reset();
        }
    }
}
