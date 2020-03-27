// Program Name : Trapezoid Area

// Author :        Ndubuisi Christopher Okpala

// Date :          24th March, 2020

// Description :   Rapid App Development for OOSD (CPRG-200-XM5)

//                 This is to write a program that will generate a compound interest table for an initial principal
//                 amount and a fixed annual interest rate. The program will prompt the user to enter the amount initially
//                 invested, the annual rate and the number of years the principal is invested. Once these information
//                 is provided, the program will format a table showing the values of the investment and the end of each year.

using System;

namespace compound_interest_investment_version_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide the following details");
            float principal;              // this will store the value of the principal amount
            float interestRate;           // this will store the value of the interest rate
            float numberOfYears;          // this will store the value of the number of years
            int counter = 0;              // this is to initialize the counter / iterative variable

            // Ask the user to input the values of principal, interest rate and number of years
            Console.Write("What is the principal amount?..");
            principal = float.Parse(Console.ReadLine());

            Console.Write("What is the interest rate?..");
            interestRate = float.Parse(Console.ReadLine()) / 100;

            Console.Write("What is the number of years?..");
            numberOfYears = float.Parse(Console.ReadLine());

            Console.WriteLine("Year            Balance");

            while (counter < numberOfYears)                                        // introducing while loop
            {
                principal = principal * (1 + interestRate);
                counter += 1;
                Console.WriteLine($"{counter}                {principal:N2}");    // this is to output the compound interest          }
           


        }
    }
}
