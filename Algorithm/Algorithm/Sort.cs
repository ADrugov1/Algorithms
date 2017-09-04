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
                array[flag] = CONST_bigNumber;
                minimumOfArray = CONST_bigNumber; 
            }
            return sortedArray;
        }
        public void InitialParams()
        { 
            minimumOfArray = CONST_bigNumber; 
        }
    }
}
