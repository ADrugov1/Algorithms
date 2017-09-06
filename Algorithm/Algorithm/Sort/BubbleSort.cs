using System.Collections.Generic;

namespace Algorithm.Sort
{
    public class BubbleSort
    {
        public List<int> Sort(List<int> array)
        {
            var iversonCounter = 1;
            for (var i = 0; i < array.Count; i++)
            {
                if (iversonCounter == 0)
                {
                    break;
                }
                iversonCounter = 0;
                for (var j = 1; j < array.Count - i; j++)
                {
                    if (array[j] < array[j - 1])
                    {
                        array.Insert(j - 1, array[j]);
                        array.RemoveAt(j+1);
                        iversonCounter++;
                    }
                }
                
            }
            return array;
        }
    }
}
