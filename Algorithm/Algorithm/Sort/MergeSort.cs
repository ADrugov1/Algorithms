using System.Collections.Generic;

namespace Algorithm.Sort
{
    public class MergeSort
    {
        public List<int> Sort(List<int> firstArray, List<int> secondArray)
        {
            var mergedArray = new List<int>();
            var mergedArrayLength = firstArray.Count + secondArray.Count;
            while (mergedArray.Count != mergedArrayLength)
            {
                if (secondArray.Count == 0)
                {
                    mergedArray.Add(firstArray[0]);
                    firstArray.RemoveAt(0);
                }
                else if (firstArray.Count == 0)
                {
                    mergedArray.Add(secondArray[0]);
                    secondArray.RemoveAt(0);
                }
                else if (secondArray[0] < firstArray[0])
                {
                    mergedArray.Add(secondArray[0]);
                    secondArray.RemoveAt(0);
                }
                else
                {
                    mergedArray.Add(firstArray[0]);
                    firstArray.RemoveAt(0);
                }
            }
            return mergedArray;
        }
    }
}
