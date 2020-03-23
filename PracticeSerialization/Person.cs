using System.Collections.Generic;

namespace PracticeSerialization
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Person> Children { get; internal set; }
    }
}