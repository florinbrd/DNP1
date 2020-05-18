namespace ConsoleApp2
{
    public class Person
    
    {
        public string Name { get; set; }
        public int age { get; set; }
        public int power { get; set;  }
        
        
        public Person(string Name, int age, int power)
        {
            this.Name = Name;
            this.age = age;
            this.power = power; 
        }

        public override string ToString()
        {
            return Name + " " + age + " " + power; 
        }
    }
}