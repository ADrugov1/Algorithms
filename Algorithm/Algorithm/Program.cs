using Algorithm.Helpers;
using System;
using System.Collections.Generic;
using Algorithm.Search;
using Algorithm.Sort;

namespace Algorithm
{
    public class Program
    {
        private const int ConstArrayLength = 100;

        private static void Main()
        {
            var randomizer = new Randomizer();
            var sorter = new QuickSort();
            var randomArray = randomizer.RandomArray(ConstArrayLength,20);
            randomArray.Add(777);
            var sortedArray = sorter.Sort(randomArray, 0, randomArray.Count - 1);
            var searcher = new HashSearch();
            searcher.Search(sortedArray,777);
        }

    }
}
