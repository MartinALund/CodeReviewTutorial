using System;

namespace CleanCoding
{
    class Program
    {
       /*  If you want to, you can try to tidy up the code in this repository. There are plenty of things that can be done!
        *  The code itself is not the primary goal of this exercise however.
        *  The actual goal is working with GIT in a way that supports code review. 
        *  
        *  
        *  You could assign half of your team to be coders trying to fix this code
        *  The other half could be reviewers, looking through your code when you submit a pull request. 
        * */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the calculator!");
            Console.WriteLine("Calculate down payment: press 1");
            Console.WriteLine("Calculate approximate loan amount: press 2");
            Calculate(Console.ReadLine());
        }

        public static void Calculate(string choice)
        {
            double housePrice;
            double procent;
            double amount;
            double year;

            if (choice == "1")
            {
                Console.WriteLine("Price of house? " );
                housePrice = Double.Parse(Console.ReadLine());
                Console.WriteLine("How many % of the total house price do you need upfront?" );
                procent = Double.Parse(Console.ReadLine());          
                amount = (housePrice / 100) * procent;
                Console.WriteLine(amount + " amount you need");
            }
            else if (choice == "2")
            {
                double monthly, approximateMultiplier;
                Console.WriteLine("Monthly income? : " );
                monthly = Double.Parse(Console.ReadLine());
                Console.WriteLine("Approximate multiplier ? ");
                approximateMultiplier = Double.Parse(Console.ReadLine());      
                year = monthly * 12;
                double housePriceApproximate = year * approximateMultiplier;
                Console.WriteLine(housePriceApproximate + " approximate purchase");
            }
            Console.ReadLine();
        }
    }
}
