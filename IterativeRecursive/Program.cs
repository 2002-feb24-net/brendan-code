using System;

namespace IterativeRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = {5,8,3,1,7,8};
            Console.WriteLine("unsorted: ["+ string.Join(",", data + "]");

            Mergesort(data);
            Console.WriteLine("sorted: ["+ string.Join(",", data + "]");

        
        }
        static int[] Subdata(int[] data, int start, int end)
        {
            int Length = end - start;
            
        }
    }
}
