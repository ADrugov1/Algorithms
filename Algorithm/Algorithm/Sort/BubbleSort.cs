using System.Collections.Generic;

namespace Algorithm.Sort
{
    public class BubbleSort
    {
        public List<int> Sort(List<int> array)
        {
            for (var i = 0; i < array.Count; i++)
            {
                for (var j = 1; j < array.Count - i; j++)
                {
                    if (array[j] < array[j - 1])
                    {
                        array.Insert(j - 1, array[j]);
                        array.RemoveAt(j+1);
                    }
                }
                
            }
            return array;
        }
    }
}
