using System;
using System.Collections.Generic;

namespace PersonList
{
    class Program
    {
        // private string Name;
        // private int Age;
        // public Person(string inputname, int inputage)
        // {
        //     Name = inputname;
        //     Age = inputage;
        // }
    
        
        static void Main()
        {
            Person person1 = new Person("John" , 18);
            Person person2 = new Person("Kenedy" , 40);
            Person person3 = new Person("Mathew" , 38);
            Person person4 = new Person("Simon" , 28);
            Person person5 = new Person("John" , 18);
            
            List<Person> people = new List<Person>();
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            people.Add(person5);

            foreach(var person in people)
            {
                System.Console.WriteLine(person.ToString());
            }

            HasDuplicate(people);
            insertSort(people);
        }

        private static bool HasDuplicate(List<Person> list)
        {
            HashSet<String> hash = new HashSet<string>();
            foreach(var per in list)
            {
                hash.Add(per.ToString());
                for(int x = 0; x < list.Count; x++)
                {
                    if(per == list[x])
                    {
                        return true;
                        
                    }
                }
            }
            return false;
        }
        
        static void insertSort (List<Person> Person) {
            for (int i = 0; i < Person.Count; i++) {
                Person personAtIndex = Person[i];
                for (int j = 1; j < i; j++) {
                    if (personAtIndex.ToString().CompareTo (Person[j].ToString()) < 0)
                        Person.Remove (personAtIndex);
                    Person.Insert (j, personAtIndex);
                }
            }
        }

    }
}
