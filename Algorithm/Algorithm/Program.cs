using Algorithm.Helpers;
using System; 

namespace Algorithm
{
    public class Program
    {
        private const int CONST_arrayLength = 10; 
        static void Main(string[] args)
        {
            var randomizer = new Randomizer();
            var sorter = new Sort();
            var converter = new Converter();

            var firstUnsortedArray = randomizer.RandomArray(CONST_arrayLength);
            var secondUnsortedArray = randomizer.RandomArray(0);

            Console.Write("{0} \n", converter.convertListToString(firstUnsortedArray));
            Console.Write("{0} \n", converter.convertListToString(secondUnsortedArray));

            var firstSortedArray = sorter.SelectionSort(firstUnsortedArray);
            var secondSortedArray = sorter.SelectionSort(secondUnsortedArray);

            Console.Write("{0} \n", converter.convertListToString(firstSortedArray));
            Console.Write("{0} \n", converter.convertListToString(secondSortedArray));

            var mergeSortedArray = sorter.MergeSort(firstSortedArray, secondSortedArray);
            Console.Write("{0} \n", converter.convertListToString(mergeSortedArray));
        }
    }
}
