using System;
using System.Threading;


namespace Constructor_Recap
{
    public class Sango
    {
        public static void Main()
        {
            Console.WriteLine("Cat");
            var animal = new Animal() { Name = "Dog" , Age = 90};
        }

    }
}

