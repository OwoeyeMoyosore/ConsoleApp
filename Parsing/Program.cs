using System;
namespace Parsing
{
    public class Program
    {
        public static void Main()
        {
            string age = "12";

            if(int.TryParse(age, out int ageValue))
            {
                Console.Write(ageValue);
            }
            else
            {
                Console.Write("Invalid age");
            }

            //nullable types
            int? year = null;  //nullable int

            peg:
            string input = Console.ReadLine();
            int? a = int.TryParse(input, out int month) ? month : 0;
            //Nullable<int> a = int.TryParse(input, out int month) ? month : 0;
            int i = a.HasValue ? a.Value : 0;
            Console.WriteLine(i);
            goto peg;

            //a.HasValue is a Non static Variable
            //int.HasValue is a static variable

            //nullable strings
            string intput = null;
            string output = intput ?? "string was null";
            Console.WriteLine(output);

                    //OR

            if (intput == null)
            {
                output = "string was null";
            }
            else
            {
                output = intput;
            }
            Console.WriteLine(output);


        } 
    }
}

