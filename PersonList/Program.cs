using System;

namespace PersonList
{
    class Person
    {
        static void Main(string[] args)
        {
            string Name = ("N/A");
            int Age = 0;
        }
        private string Name
        {
            get
            {
                return Name;
            }
            set 
            {
                Name = value;
            }
        }
        private int Age
        {
            get
            {
                return Age;
            }
            set
            {
                Age = value;
            }
        }
        private override string ToString()
        {
            return "Name = " + Name + ", Age = " + Age;
        }
        static void Main()
        {
            Person person = new Person();
            Console.WriteLine("Person details - {0}" person);

            person.Name = "Kahwi";
            person.Age = 30;
            Console.WriteLine("Person details - {0}" person);
        }
        static void Main()
        {
            List<Person> persons = new List<Person>();

            persons.Add(new Person { PersonName = "Mark"});
            persons.Add(new Person { Person2Name = "Apollo"});
            persons.Add(new Person { Person3Name = "Simon"});
            persons.Add(new Person { Person4Name = "Jude"});
            persons.Add(new Person { Person5Name = "Desmond"});

            Console.WriteLine();
            foreach (Person aPerson in persons)
            {
                Console.WriteLine(aPerson);
            }
            bool hasDuplicates<T>(List<T> myList)
            {
                var name = new HashSet<T>();
                for (var i = 0; i < myList.count; i++)
                {
                    if (!name.Add(myList[i])) 
                    return true;

                    else
                    {
                        return false;
                    }
                }
            }
            static string[] // this method was to implement an insertion and sort method 


            // a bubble sort will sort through an array or a group of numbers in pairs over and over until 
            // the numbers are completely sorted and put in order. 
            // an insertion sort builds the final sorted array one item at a time until it is finally sorted.
        
        }
    }
}
