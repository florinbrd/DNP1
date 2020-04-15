namespace ConsoleApp1
{
    public class Person
    {
        private string name { get; set;  }
        private int age { get; set;  }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age; 
        }

        public override string ToString()
        {
            return "hello" + name + " age: " + age; 
        }
    }
}