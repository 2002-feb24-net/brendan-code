using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            var list2 = new List<string>();


            var sortedlist = new sortedSequence<string>();
            sortedlist.Add("asdf");
            sortedlist.Add("as");
            sortedlist.Add("a");
            for (int i = 0; i < 3; i++)
            {
                string s = sortedlist[i];
                Console.Write(s + " ");
            }
        }
        private static void ArrayList()
        {
            var arraylist = new ArrayList();
            arraylist.Add(1);
            arraylist.Add(2);
            arraylist.Add(3);
            arraylist.Add( new ArrayList());
            arraylist.Add("asdf");
            foreach (int num in arraylist)
            {
                Console.Write($"{num + 1} ");
            }
        }
    }
}





    



