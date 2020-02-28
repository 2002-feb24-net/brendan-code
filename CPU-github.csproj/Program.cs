
using System;

namespace name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text in a Line");

            string nstring = Console.ReadLine();


            string[] estring = nstring.Split(" ");


            
            for (int i = 0; i < estring.Length; i++)
            {    //searching through e string array and printing the first index
                // and ignoring every other index after.
                Console.Write(estring[i].Substring(0, 1));


            }


        }
    }
}
