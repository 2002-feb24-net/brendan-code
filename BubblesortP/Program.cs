using System;

namespace BubblesortP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Unsorted = {1,3,2,5,4,7,8};
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
                for (var sort = 0; sort < data.Length - 1; sort++)
                {
                    if (data[sort] > (data[sort + 1])            
                    {
                    var oldValue = data[sort + 1];
                    data[sort + 1] = data[sort];
                    data[sort] = oldValue;
                    hasSwapped = true;
                    }
                }
            }
            while (hasSwapped);
        }
        
    }
}
