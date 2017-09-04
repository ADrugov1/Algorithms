namespace Algorithm.Helpers
{
    public class Randomizer
    {
        public int[] RandomArray(int arrayLength)
        {
            var array = new int[arrayLength];
            var rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next();
            }
        }
    }
}
