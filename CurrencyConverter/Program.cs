using System;
namespace CurrencyConverter
{
    public class Program
    {
        public static void Main()
        {
            double amount;
            string currency;
            const double nairadollar = 580;
            const double nairaeuro = 400;
            const double nairapounds = 300;

            //Console.WriteLine("Enter the currency: ");
            //currency = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the amount:  ");
            amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(amount + " Dollar is " + amount * nairadollar);
            Console.WriteLine(amount + " Euro is " + amount * nairaeuro);
            Console.WriteLine(amount + " Pounds is " + amount * nairapounds);

        }

    }

   
    
}