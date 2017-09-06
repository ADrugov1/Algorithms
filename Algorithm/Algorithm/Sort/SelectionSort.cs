using System.Collections.Generic;

namespace Algorithm.Sort
{
    public class SelectionSort
    {
        public int MinimumOfArray = CONST_bigNumber;
        public int Flag;
        private const int CONST_bigNumber = 99999;
        public List<int> Sort(List<int> array)
        {
            var sortedArray = new List<int>();
            for (var i = 0; i < array.Count; i++)
            {
                for (var j = 0; j < array.Count; j++)
                {
                    if (MinimumOfArray >= array[j])
                    {
                        MinimumOfArray = array[j];
                        Flag = j;
                    }
                }
                sortedArray.Add(MinimumOfArray);
                array[Flag] = CONST_bigNumber;
                MinimumOfArray = CONST_bigNumber;
            }
            return sortedArray;
        }
    }
}
