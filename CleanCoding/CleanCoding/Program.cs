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
            calculate(int.Parse(Console.ReadLine()));
        }

        public static void calculate(int userPick)
        {
            if(userPick == 1)
            {
                double housePrice, percentNow;
                Console.WriteLine("Price of a house? " );
                housePrice = Double.Parse(Console.ReadLine());
                Console.WriteLine("How many % of the total house price do you need upfront?" );
                percentNow = Double.Parse(Console.ReadLine());
                double upfrontPayment = (housePrice / 100) * percentNow;
                Console.WriteLine(upfrontPayment + " amount you need");
            }
            else if (t == "2")
            {
                double m, a;
                Console.WriteLine("Monthly income? : " );
                m = Double.Parse(Console.ReadLine());
                Console.WriteLine("Approximate multiplier ? ");
                a = Double.Parse(Console.ReadLine());
                double y = m * 12;
                double hpa = y * a;
                Console.WriteLine(hpa + " approximate purchase");
            }
            Console.ReadLine();
        }
    }
}
