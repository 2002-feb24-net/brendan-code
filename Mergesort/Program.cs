using System;

namespace Mergesort
{
    class Program
    {
        static void main(string[] args)
        {
            int[] array = {1,5,7,3,9,6,7};
            Console.WriteLine("before sort: [" + string.Join(",", array) + "]");

            Mergesort(array);
            Console.WriteLine("after sort: [" + string.Join(",", array) + "]");

        }
        static void Mergesort(int[] array)
        {
            int middle = array.Length / 2;
            int[] left = SubArray(array, 0, middle);
            int[] right = SubArray(array, middle, array.Length);

            Mergesort(left);
            Mergesort(right);

            int l = 0;
            int r = 0;
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if(l >= left.Length)
                {
                    result[i] = right[r];
                }
                else if (r >= right.Length)
                {
                    result[i] = right[l];
                }
                if(left[l] <= right[r])
                {
                    result[i] = left[l];
                    l++;
                }
                else
                {
                    result[i] = right[r];
                    r++;
                }
            }
        }
        static int[] SubArray(int[] array, int start, int end)
        {
            int length = end - start;
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = array[start + i];
            }
            return result;
        
        
          
        }
    }
}
