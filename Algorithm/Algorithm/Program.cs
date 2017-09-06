using Algorithm.Helpers;
using System;
using Algorithm.Sort;

namespace Algorithm
{
    public class Program
    {
        private const int ConstArrayLength = 10;

        private static void Main()
        {
            var randomizer = new Randomizer();
            var sorter = new QuickSort();
            var converter = new Converter();

            var firstUnsortedArray = randomizer.RandomArray(ConstArrayLength);

            Console.Write("{0} \n", converter.ConvertListToString(firstUnsortedArray));

            var firstSortedArray = sorter.Sort(firstUnsortedArray,0,firstUnsortedArray.Count-1);

            Console.Write("{0} \n", converter.ConvertListToString(firstSortedArray));

         }

    }
}
