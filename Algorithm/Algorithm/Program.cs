using Algorithm.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var unsortedArray = randomizer.RandomArray(CONST_arrayLength);
            Console.Write("{0} \n", converter.convertListToString(unsortedArray));
            var sortedArray = sorter.SelectionSort(unsortedArray);
            Console.Write("{0} \n", converter.convertListToString(sortedArray));
        }
    }
}
