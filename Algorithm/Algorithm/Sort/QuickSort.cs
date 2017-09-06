using System.Collections.Generic;

namespace Algorithm.Sort
{
    public class QuickSort
    {       
        public int Key(List<int> array, int start, int end)
        {
            int temp;
            var marker = start;
            for (var i = start; i <= end; i++)
            {
                if (array[i] < array[end]) 
                {
                    temp = array[marker]; 
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            temp = array[marker];
            array[marker] = array[end];
            array[end] = temp;
            return marker;
        }

        public List<int> Sort(List<int> array, int start, int end)
        {
            if (start >= end)
            {
                return array;
            }
            var key = Key(array, start, end);

            Sort(array, start, key - 1);
            Sort(array, key + 1, end);

            return array;
        }
    }
}
