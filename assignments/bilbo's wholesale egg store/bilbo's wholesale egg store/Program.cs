// Program Name : Trapezoid Area

// Author :        Ndubuisi Christopher Okpala

// Date :          24th March, 2020

// Description :   Rapid App Development for OOSD (CPRG-200-XM5)

//                 This is a program that will ask the user for number of eggs purchased and then
//                 calculate the total price for the user to be paid

using System;

namespace bilbo_s_wholesale_egg_store
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEggs;   // This will store the value of the number of eggs
            double price;       // This will store the value of the total price

            // Ask the user the number of eggs purchased

            Console.Write("What is the number of egg ?..");
            numberOfEggs = int.Parse(Console.ReadLine());

            if ((numberOfEggs >= 0) && (numberOfEggs < 48))
            {
                price = (0.50 / 12) * numberOfEggs;                    // calculate the price for the user                
            }
            else if ((numberOfEggs >= 48) && (numberOfEggs < 72))
            {
                price = (0.45 / 12) * numberOfEggs;                    // calculate the price for the user                
            }
            else if ((numberOfEggs >= 72) && (numberOfEggs < 132))     
            {
                price = (0.40 / 12) * numberOfEggs;                    // calculate the price for the user                
            }
            else
            {
                price = 0.35 / 12 * numberOfEggs;                      // calculate the price for the user                
            }
            Console.WriteLine($"Your bill is $ {price:N2}");            // output the total amount to be paid based on the number of eggs purchased
        }
    }
}
