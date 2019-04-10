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

        public static void Calculate(string userInput)
        {
            if(userInput == "1")
            {
                Console.WriteLine("Price of house? " );
                double priceOfHouse = Double.Parse(Console.ReadLine());
                Console.WriteLine("How many % of the total house price do you need upfront?" );
                double upFrontPayment = Double.Parse(Console.ReadLine());          
                double a = (priceOfHouse / 100) * upFrontPayment;
                Console.WriteLine(a + " amount you need");
            }
            else if (userInput == "2")
            {
                double monthlyInterest;
                Console.WriteLine("Monthly income? : " );
                double monthlyIncome = Double.Parse(Console.ReadLine());
                Console.WriteLine("Approximate multiplier ? ");
                monthlyInterest = Double.Parse(Console.ReadLine());      
                double y = monthlyIncome * 12;
                double hpa = y * monthlyInterest;
                Console.WriteLine(hpa + " approximate purchase");
            }
            Console.ReadLine();
        }
    }
}
