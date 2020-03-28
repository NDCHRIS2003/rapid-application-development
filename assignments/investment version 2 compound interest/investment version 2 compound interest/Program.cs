// Program Name : Trapezoid Area

// Author :        Ndubuisi Christopher Okpala

// Date :          24th March, 2020

// Description :   Rapid App Development for OOSD (CPRG-200-XM5)

//                 This is to write a program that will prompt the user of the principal amount invested. Then it will 
//                 prompt the user of each years interest rate. The user will need to input zero to indicate the final year
//                 has been reached and the accumulated value of the investment will be output to the user. It will also
//                 display the average year income returned by the investment.

using System;

namespace investment_version_2_compound_interest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide the following details");
            float principal;                               // this will store the value of the principal amount
            float interestRate;                            // this will store the value of the interest rate            
            float compoundInterest = 1000;                        // this will store the value of the compound interest
            float averageYearlyIncome;                     // this will store the value of the income

            // Ask the user to input the values of principal amount and the initial interest rate in percent
            Console.Write("What is the principal amount?..");
            principal = float.Parse(Console.ReadLine());

            Console.Write("What is the initial interest rate (in percent)?: ");
            interestRate = float.Parse(Console.ReadLine()) / 100;             
            
            // introducing a sentinel control loop and ask the user to provide interest rate of each year
            while (interestRate != 0)                                                
            {
                compoundInterest = compoundInterest * (1 + interestRate);
                Console.Write("What is the yearly interest rate (in percentage)? : ");
                interestRate = float.Parse(Console.ReadLine()) / 100;                
            }
            // calculate the value of income and output the value of compound interest average yearly income at the end of 3 years
            averageYearlyIncome = (compoundInterest - principal) / 3;
            Console.WriteLine($"At the end of 3 years, your investment will be worth ${compoundInterest:N2} and your average yearly income is ${averageYearlyIncome:N2}");
        }
    }
}
