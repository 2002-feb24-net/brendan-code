using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace Serialization
{
    class Program
    {
        
        static async Task Main(string[] args)
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

                await WriteToFileAysnc(json1, filePath);
            }
            else
            {
                string json3 = await ReadFromFileAsync(filePath);
                data = JsonSerializer.Deserialize<List<Person>>(json3);
            }
            ModifyPersons(data);
            string json2 = ConvertToJson(data);
            await WriteToFileAsync(json2, filePath);
            
        }
        
        private async static Task<string> ReadFromFileAsync(string filePath)
        {
            var sr = new StreamReader(filePath);
            string text = await sr.ReadToEndAsync();
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


        private async static Task WriteToFileAsync(string text, string path)
        {
            var file = new FileStream("data.json", FileMode.Create);
            byte[] data = Encoding.UTF8.GetBytes(text);
            await file.WriteAsync(data);
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
