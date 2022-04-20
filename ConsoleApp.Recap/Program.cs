using System;

namespace ConsoleApp.Recap
{
    public class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            PrintNumbers(numbers);
            PrintNumbers(1, 2, 3, 4, 5); //You can just use this in place of Line 9 and 10
        }
        //You can have more than one constructor of the same name
        public static void PrintNumbers(params int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}

