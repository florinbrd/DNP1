using System;

namespace ConsoleApp1
{
    public class DNPStudent : Student
    {
        public override void sayHi()
        {
            Console.WriteLine("I am a DNP Student y'all");
            base.sayHi(); // we call here the baseline method, not mandatory 
        }
    }
}