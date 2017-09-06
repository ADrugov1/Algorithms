using System.Collections.Generic;

namespace Algorithm.Sort
{
    public class ShakerSort
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
                if (i % 2 == 0)
                    for (var j = i/2+1; j < array.Count - i/2; j++)
                    {
                        if (array[j] < array[j - 1])
                        {
                            array.Insert(j - 1, array[j]);
                            array.RemoveAt(j + 1);
                            iversonCounter++;
                        }
                    }
                else
                {
                    for (var j = array.Count - i/2 -1 ; j >= i/2 + 1; j--)
                    {
                        if (array[j] < array[j - 1])
                        {
                            array.Insert(j - 1, array[j]);
                            array.RemoveAt(j + 1);
                            iversonCounter++;
                        }
                    }
                }
            }
            return array;
        }
    }
}
