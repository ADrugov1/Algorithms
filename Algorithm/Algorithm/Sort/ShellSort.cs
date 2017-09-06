using System.Collections.Generic;

namespace Algorithm.Sort
{
    public class ShellSort
    {
        public List<int> Sort(List<int> array)
        {
            {
                var iversonCounter = 1;
                for (var i = 0; i < array.Count; i++)
                {
                    if (iversonCounter == 0)
                    {
                        break;
                    }
                    iversonCounter = 0;
                    var d = (array.Count-i) / 2;
                    do
                    {
                        for (var j = 0; j < array.Count - d; j++)
                        {
                            if (array[j + d] < array[j])
                            {
                                var parametr = array[j];
                                array[j] = array[j + d];
                                array[j + d] = parametr;
                                iversonCounter++;
                            }
                        }
                        d = d / 2;
                    } while (d != 0);

                }
                return array;
            }
        }
    }
}
