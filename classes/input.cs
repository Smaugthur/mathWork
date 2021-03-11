using System;

namespace INPUT
{
    class InputMethods
    {
        public static int[] inputArray()
        {
            string[] StringInput= Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            int[] input = Array.ConvertAll(StringInput, s => int.Parse(s));
            Array.Sort(input);
            Console.Clear();
            return input;
        }
    }
}