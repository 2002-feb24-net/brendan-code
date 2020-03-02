using System;

namespace name
{
    class Program
    {
        static void Main(string[] args)
        {
           int Fizz = 0;
           int Buzz = 0;
           int FizzBuzz = 0; 

        for (int i = 0; i < 1000; i++)
        {

            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
                FizzBuzz++;
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
                Fizz++;
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
                Buzz++;
            }
            else 
            {
                Console.WriteLine(i);
            }
                
        }
        System.Console.WriteLine("Fizz appeared " + Fizz + "times!");
        System.Console.WriteLine("Buzz appeared " + Buzz + "times!");
        System.Console.WriteLine("FizzBuzz appeared " + FizzBuzz + "times!");
            
        }
    }
}
