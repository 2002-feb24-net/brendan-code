using System;

namespace Bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Unsorted = {2,4,5,3,6,8,9};
            Bubblesort(Unsorted);
            for (int i = 0; i < Unsorted.Length; i++)
            {
                Console.WriteLine(Unsorted[i]);
            }
        }
        static void Bubblesort(int[] input)
        {
            bool hasSwapped;
            do
            {
                hasSwapped = false;
                for (var sort = 0; sort < input.Length - 1; sort++)
                {
                    if (input[sort] > input[sort + 1])
                    {
                        var oldValue = input[sort + 1];
                        input[sort + 1] = input[sort];
                        input[sort] = oldValue;
                        hasSwapped = true;
                    }
                }
            }
            while (hasSwapped);
        }
    }
}
