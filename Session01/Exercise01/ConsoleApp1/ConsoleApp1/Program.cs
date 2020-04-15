//Create a new Person class in a separate file. The class should contain a name property and an Introduce method that prints
//“Hi, I am (name)” to the console. In the Main method of the Program class,
//create an instance of the Person class, specifying the name property with object 
//initializer notation and then call the Introduce method on the object.



using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
            Name = "Florin",
            };
            
            person.Introduce();
        }
    }
    }

