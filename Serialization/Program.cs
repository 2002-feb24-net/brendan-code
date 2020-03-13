using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "../../../data.json";
            // in.NET, for XML serialization, we have 
            //  - DataContractSerializer
            // - XMLSerializer (old, non-generic)
            // for JSON serilization, we have 
            // - 
            List<Person> data = null;
            if (!File.Exists(filePath))
            {
                data = GetInitialData();
                string json1 = ConvertToJson(data);

                WriteToFile(json1, filePath);
            }
            else
            {
                string json3 = ReadFromFile(filePath);
                data = JsonSerializer.Deserialize<List<Person>>(json3);
            }
            ModifyPersons(data);
            string json2 = ConvertToJson(data);
            WriteToFile(json2, filePath);
            
        }
        private static string ReadFromFile(string filePath)
        {
            var sr = new StreamReader(filePath);
            string text = sr.ReadToEnd();
            sr.Close();
            return text;
        }
        private static void ModifyPersons(List<Person> data)
        {
            foreach (var person in data)
            {
                person.Id++;
            }
        }


        private static void WriteToFile(string text, string path)
        {
            var file = new FileStream("data.json", FileMode.Create);
            byte[] data = Encoding.UTF8.GetBytes(text);
            file.Write(data);
            file.Close();
        }
        static string ConvertToJson(List<Person> data)
        {
            return JsonSerializer.Serialize(data);
        }
         static List<Person> GetInitialData()
        {
            var list = new List<Person>();
            var nick = new Person();
            nick.Id = 1;
            nick.Name = "Nick";

            var mark = new Person();
            mark.Id = 2;
            mark.Name = "Mark";
            mark.Children = new List<Person>
            {
                new Person {Id = 3, Name = "Ethan" },
                new Person {Id = 4, Name = "Hope" },
                new Person {Id = 5, Name = "Odom"},
            };
            list.Add(nick);
            list.Add(mark);
            return list;                

        }
        
    }
}
