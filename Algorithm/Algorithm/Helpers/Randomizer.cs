using System;
using System.Collections.Generic;
namespace Algorithm.Helpers
{
    public class Randomizer
    {
        public List<int> RandomArray(int arrayLength,int maxValue)
        {
            var array = new List<int>();
            var rand = new Random((int)DateTime.Now.Ticks);
            for (var i = 0; i < arrayLength; i++)
            {
                array.Add(rand.Next(maxValue));
            }
            return array;
        }
    }
}
