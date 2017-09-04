using System;
using System.Collections.Generic;
namespace Algorithm.Helpers
{
    public class Randomizer
    {
        public List<int> RandomArray(int arrayLength)
        {
            var array = new List<int>();
            var rand = new Random();
            for (int i = 0; i < arrayLength; i++)
            {
                array.Add(rand.Next(1000));
            }
            return array;
        }
    }
}
