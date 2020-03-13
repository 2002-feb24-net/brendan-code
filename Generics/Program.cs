using System;
using System.Collections;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayLists();
            // whenever we use a type with <> at the end 
            // that is a generic type
            //and the specific thing you put in the <> is called the type parameter.
            var list = new List<int>();
            var list2 = new List<string>();

            var sortedlist = new SortedSequence<string>();
            sortedlist.Add("asdf");
            sortedlist.Add()
            SortedList.Add()


         }   

        private static void ArrayLists()
        {
            var arraylist = new ArrayList();
            // this can be used in any situation for an array list and interger in combination.
            arraylist.Add(1);
            arraylist.Add(2);
            arraylist.Add(3);
            arraylist.Add(new ArrayList());
            arraylist.Add("asdf");
            // when used with the non-generic IEnumerable interface
            // it will attempt to cast to whatever type you put here.

            foreach (int num in arraylist)
            {
                Console.Write($"{num + 1} ");
            }
        }
    }
}
