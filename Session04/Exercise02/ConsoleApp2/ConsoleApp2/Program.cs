using System;
using System.IO;
using System.IO.Enumeration;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.ssn = 11;
            p.Name = "Florin";
            p.lastName = "Bordei";
            
            IFormatter formatter = new BinaryFormatter();
            Stream strem = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(strem, p);
            
            strem.Close();
            
            // Deserialize 
            
            IFormatter formatter2 = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Person person = (Person) formatter.Deserialize(stream);
            stream.Close();
            
            Console.WriteLine(person.Name);
            Console.WriteLine(person.lastName);
            Console.WriteLine(person.ssn);
            
            //Json 

            string json;
            
            json = JsonSerializer.Serialize(p);
            Console.WriteLine(json);

            var per = JsonSerializer.Deserialize<Person>(json);
            
            Console.WriteLine(per.Name);
            Console.WriteLine(per.lastName);
            Console.WriteLine(per.ssn);
            
            
        }
    }
}