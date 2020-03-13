using System;

namespace FizzBuzzPractice
{
    class FizzBuzzGame
    {
        static void Main(string[] args)
        {
            int[] Unsorted = {3,2,4,1,5,6,8,7};
            Bubblesort(Unsorted);
            for (int i = 0; i < Unsorted.Length; i++)
            {
                Console.WriteLine(Unsorted[i]);
            }
            
        }
        static void Bubblesort(int[] data)
        {
            bool hasSwapped;
            do
            {
                hasSwapped = false;
                for (var sort = 0; sort < data.Length; sort++)
                {
                    if (data [sort] > data [sort + 1])
                    {
                        var oldValue = data [sort + 1];
                        data [sort + 1] = data [sort];
                        data [sort] = oldValue;
                        hasSwapped = true;
                    }

                }
            }
            while(hasSwapped);
        }
    }
}
