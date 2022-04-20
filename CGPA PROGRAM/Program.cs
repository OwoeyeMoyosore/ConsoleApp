 using System;
namespace cGPA
{
    public class Grades
    {
        public static double score;
        //public static string grade;
        public static void Main()
        {
            ginger:
            Console.Write("Enter your CGPA: ");
            score = Convert.ToDouble(Console.ReadLine());
            //score++;

            if (score <= 5.00 && score >= 4.5)
            {
                Console.WriteLine("First class, Excellent");
                
            }
            else if(score <= 4.49 && score >= 3.5 )
            {
                Console.WriteLine("Second class upper");
            }
            else if (score <= 3.49 && score >= 2.5)
            {
                Console.WriteLine("Second class lower");
            }
            else if (score <= 2.49 && score >= 1.5)
            {
                Console.WriteLine("Third class ");
            }
            else if (score <= 1.49 && score >= 0)
            {
                Console.WriteLine("You Failed, OLODO");
            }
            else
            {
                Console.WriteLine("Invalid Score");
            }
            goto ginger;


          
        }

    }
    }
