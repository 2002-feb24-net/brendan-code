using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PracticeSerialization
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string filePath = "data.json";

            List<Person> data = null;
            if (!File.Exists(filePath))
            {
                data = GetInitialData();
                string json1 = ConvertToJson(data);

                try
                {
                    await WriteToFileAsync(json1, filePath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Fatal error");
                    Console.WriteLine(ex.Message);
                    return;
                }
            }
            else
            {
                string json3 = await ReadFromFileAsync(filePath);
                data = JsonSerializer.Deserialize<List<Person>>(json3);
            }
            ModifyPerson(data);

            string json2 = ConvertToJson(data);

            try
            {
                await WriteToFileAsync(json2, filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fatal error");
                Console.WriteLine(ex.Message);
                return;
            }



        }
        private async static Task<string> ReadFromFileAsync(string filePath)
        {
            using var sr = new StreamReader(filePath);
            Task<string> textTask = sr.ReadToEndAsync();
            string text = await textTask;
            return text;
        }
        private static void ModifyPerson(List<Person> data)
        {
            foreach (var person in data)
            {
                person.Id++;
            }
        }
        private async static Task WriteToFileAsync(string text, string path)
        {
            FileStream file = null;
            try
            {
                file = new FileStream(path, FileMode.Create);
                byte[] data = Encoding.UTF8.GetBytes(text);

                await file.WriteAsync(data);
            }
            catch (System.UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Access to file {path} is not allowed by the OS:");
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                if (file != null)
                {
                    file.Dispose();
                }
            }
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
                new Person { Id = 3, Name = "Ethan" },
                new Person { Id = 4, Name = "Hope" },
                new Person { Id = 5, Name = "Maya" }
            };

            list.Add(nick);
            list.Add(mark);
            return list;
        }
    }
}

