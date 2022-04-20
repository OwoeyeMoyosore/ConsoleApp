using System;
namespace SwitchCGPA
{
    
    public class Grades
    {
        public static double score;
        public static string currentClass;
        
        
        static void Main()
        {
        rerun:
            Console.WriteLine("\n");
            Console.WriteLine("Enter your Score to Compute GPA:  ");
            score = Convert.ToDouble(Console.ReadLine());
            
            switch (score)
            {
                case double score when score >= 4.5 && score <= 5.0:
                    currentClass = "First Class";
                break;
                case double score when score >= 3.5 && score <= 4.49:
                    currentClass = "Second Class Upper";
                break;
                case double score when score >= 2.5 && score <= 3.49:
                    currentClass = "Second Class Lower";
                break;
                case double score when score >= 1.5 && score <= 2.49:
                    currentClass = "Third Class";
                break;
                case double score when score >= 0 && score <= 1.49:
                    currentClass = "You Failed";
                break;

                default:
                    currentClass = "Invalid";
                break;
            }
            Console.WriteLine("Your Grade is " + currentClass);
            goto rerun;

        }
    }
}