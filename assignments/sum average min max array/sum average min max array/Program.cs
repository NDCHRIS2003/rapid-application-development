// Program Name : Application to determine the sum, the mean(average), the minimum and the maximum value
//                of numbers.

// Author :        Ndubuisi Christopher Okpala

// Date :          24th March, 2020

// Description :   Rapid App Development for OOSD (CPRG-200-XM5)

//                 This application will prompt the user to provide ten different numbers ranging
//                 from 0 to 100. After which, it will store those numbers in a single array and 
//                 out put the values inputed to the user along with total value of figures inputed,
//                 The mean, minimum and maximum values respectively in an organized form.

using System;
using System.Linq;

namespace sum_average_min_max_array
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ARRAY_SIZE   = 10;                        // This is to declare the size of array
            decimal[] arrayNumbers = new decimal[ARRAY_SIZE];   // This is to declare the decimal array and to also 
                                                                // initialize it with the size of the array
            int numberValue        = 0;                         // This will store the value of arrays inputed by the user.

            //Introducing a do-while loop to ensure that immediately the user finishes to input 10 values, it will
            // jump out of the loop to evalute the Total,mean, minimum and maximum values respectively.
            // the data sanitization statements such as "if statement" is to ensure that the user do not input any
            // value that is not in the range of 0 and 100. The "try-catch" statement is to ensure that the application
            // will not crash when ever a user inputs any non numeric value or any other error that might arise while
            // processing the input values            

            do
            {
                try
                {
                    Console.WriteLine("Please enter 10 values between 0 and 100");
                    arrayNumbers[numberValue] = decimal.Parse(Console.ReadLine());

                    if(arrayNumbers[numberValue] < 0 || arrayNumbers[numberValue] > 100)
                    {
                        Console.WriteLine($"The number you entered is out of range.You entered {arrayNumbers[numberValue]}.\n Please try again");
                    }
                    else
                    {
                        numberValue++;
                    }
                    
                }
                catch (Exception excp)
                {
                    Console.WriteLine($"The value you entered is non numeric. \n {excp.Message} Please Try again.");
                }


            } while (numberValue < ARRAY_SIZE);

            // The foreach loop is to output all the values provided by the user

            foreach (int value in arrayNumbers)
            {
                Console.WriteLine($"Values Entered: {value,11:N2}");
            }

            // this is to display the Total, Mean, Minimum and Maximum values provided by the user

            Console.WriteLine($"Total:  {arrayNumbers.Sum(),20:N2}");

            Console.WriteLine($"Mean:   {arrayNumbers.Average(),19:N2}");

            Console.WriteLine($"Minumum:{arrayNumbers.Min(),19:N2}");

            Console.WriteLine($"Maximum:{arrayNumbers.Max(),19:N2}");        





        }
    }
}
