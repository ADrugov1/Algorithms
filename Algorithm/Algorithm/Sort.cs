using Algorithm.Helpers;
using System.Collections.Generic;
namespace Algorithm
{
    public class Sort
    {
        public int minimumOfArray = CONST_bigNumber;
        public int flag;
        private const int CONST_bigNumber = 99999;
        private const int CONST_smallNumber = -99999;
        public List<int> SelectionSort(List<int> array)
        {
            var sortedArray = new List<int>();
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array.Count; j++) 
                {
                    if (minimumOfArray >= array[j])
                    {
                        minimumOfArray = array[j];
                        flag = j;
                    }
                }
                sortedArray.Add(minimumOfArray);
                array[flag] =  CONST_bigNumber;
                minimumOfArray = CONST_bigNumber; 
            }
            return sortedArray;
        }

        public List<int> MergeSort(List<int> firstArray, List<int> secondArray)
        {
            List<int> mergedArray = new List<int>();
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
        public void InitialParams()
        { 
            minimumOfArray = CONST_bigNumber; 
        }
    }
}
