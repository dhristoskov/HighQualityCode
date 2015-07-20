using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.SortingAlgorithms
{
    internal class MergeSort
    {
        /// <summary>
        /// Merge Sort Algorithm
        /// </summary>
        /// <param name="collection">unsorted collection</param>
        /// <param name="leftIndex">start index of collection to be sorted</param>
        /// <param name="rightIndex">end index of collection to be sorted</param>
        /// <returns>sorted collection</returns>
        public static List<int> MergeSortAlgorithm(List<int> collection, int leftIndex, int rightIndex)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection), "Collection ca not be null!");
            }

            if (leftIndex >= rightIndex)
            {
                return collection;
            }

            int middleIndex = (leftIndex + rightIndex)/2;

            MergeSortAlgorithm(collection, leftIndex, middleIndex);
            MergeSortAlgorithm(collection, middleIndex + 1, rightIndex);

            int[] leftSide = new int[middleIndex - leftIndex + 1];
            int[] rightSide = new int[rightIndex - middleIndex];

            collection.CopyTo(0, leftSide, 0, middleIndex - leftIndex + 1);
            collection.CopyTo(middleIndex + 1, rightSide, 0, rightIndex - middleIndex);

            Utils.StopWatch.Start();

            int i = 0;
            int j = 0;
            for (int k = leftIndex; k < rightIndex + 1; k++)
            {
                if (i == leftSide.Length)
                {
                    collection[k] = rightSide[j];
                    j++;
                }
                else if (j == rightSide.Length)
                {
                    collection[k] = leftSide[i];
                    i++;
                }
                else if (leftSide[i] <= rightSide[j])
                {
                    collection[k] = leftSide[i];
                    i++;
                }
                else
                {
                    collection[k] = rightSide[j];
                    j++;
                }
            }

            Utils.StopWatch.Stop();
            Utils.ElepsedTime = Utils.StopWatch.Elapsed;

            return collection;            
        }
    }
}
