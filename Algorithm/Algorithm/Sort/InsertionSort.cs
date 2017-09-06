using System.Collections.Generic;

namespace Algorithm.Sort
{
    public class InsertionSort
    {
        public List<int> Sort(List<int> array)
        {
            for (var i = 1; i < array.Count; i++)
            {
                var sortedElement = array[i]; 
                for (var j = i - 1; j >= 0; j--)
                {
                    if (sortedElement < array[j])
                    {
                        if (j != 0) continue;
                        array.Insert(0, sortedElement);
                        array.RemoveAt(i + 1);
                    }
                    else
                    {
                        array.Insert(j + 1, sortedElement);
                        array.RemoveAt(i + 1);
                        break;
                    }
                }
             }
            return array;
        }
    }
}
