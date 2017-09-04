using System.Collections.Generic;
namespace Algorithm.Helpers
{
    public class Converter
    {
        public string convertListToString(List<int> array)
        {
            return string.Join(",", array);
        }
    }
}
