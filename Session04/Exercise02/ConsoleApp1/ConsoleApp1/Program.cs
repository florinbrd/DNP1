using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           Person p = new Person();
           p.firstName = "Florin";
           p.lastName = "Bordei";
           p.ssn = 1234; 
           
           // serialized 
           
           IFormatter formatter = new BinaryFormatter();
           Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
           formatter.Serialize(stream, p);
           stream.Close();
           
           // deserialized 

           IFormatter formater_read = new BinaryFormatter(); 
           Stream stream_read = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);

           Person p_new = (Person) formater_read.Deserialize(stream_read);
           stream.Close();
           
           Console.WriteLine(p.firstName + " " + p.lastName + " " + p.ssn);
           
           // serialize and deserialize to a json 
           
           Person p_json = new Person();
           p_json.firstName = "Test";
           p_json.lastName = "Person";
           p_json.ssn = 1212;

           string jsonString;
           jsonString = JsonSerializer.Serialize(p_json);
           
           Console.WriteLine(jsonString);

           var person = JsonSerializer.Deserialize<Person>(jsonString);
           Console.WriteLine(person.firstName + " " + person.lastName + " " + person.ssn);
           
           //private static void SaveJSON()
           //{
            //   var person = new Person() { FirstName = "Jakob", LastName = "Knop", Ssn = 1337 };
//
  //             File.WriteAllText("MyFile.json", JsonSerializer.Serialize(person));
//
  //             Console.WriteLine("The Person has been saved to JSON file");
    //       }
//
  //         private static void LoadJSON()
    //       {
      //         var person = JsonSerializer.Deserialize<Person>(File.ReadAllText("MyFile.json"));
//
  //             Console.WriteLine("The Person has been read from JSON file");
    //           Console.WriteLine($"Fullname: {person.FullName()}");
      //         Console.WriteLine($"SSN: {person.Ssn}");
        //   }

        }
    }
}