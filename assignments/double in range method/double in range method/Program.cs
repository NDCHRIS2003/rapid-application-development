// Program Name : Technical Support

// Author :        Ndubuisi Christopher Okpala

// Date :          24th March, 2020

// Description :   Rapid App Development for OOSD (CPRG-200-XM5)

//                 This program will ask the user to provide a double type numbers that must fall between
//                 a minimum and maximum values. It will also validate that the user inputs a value that is 
//                 between the initial minimum and maximum values inputed and also output the correct value
//                 provided by the user.

using System;

namespace double_in_range_method
{
    class Program
    {
        // introducing a method getDoubleInRange that will be used in the subsequent program
        static double getDoubleInRange(string prompt, double minimum, double maximum, string error)
        {
            double value;      // this will store the parameter value
            bool confirm;      // this is a bool used to confirm the data validation

            // to get the values for the metthod getDoubleInRange
            do
            {
                Console.Write(prompt);
                if (!double.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("**** Non-numeric value entered. Try again. ");
                    confirm = false;
                }
                else
                {
                    if ((value < minimum) || (value > maximum))
                    {
                        Console.WriteLine(error);
                        confirm = false;
                    }
                    else
                    {
                        confirm = true;
                    }
                }
            } while (!confirm);
            return value;
        }


        static void Main(string[] args)
        {
            double maximum;            // this will store the value for maximum
            double minimum;            // this will store the value for minimum
            double value;              // this will store the value for value            
            bool   confirm;            // this is a booleon statement to validate the data

            // to get and validates the values of maximum, minimum 
            do
            {
                Console.Write("Enter minimum value in range. ");
                minimum = double.Parse(Console.ReadLine());
                if ((minimum < 0) || (minimum > 100))
                {
                    Console.WriteLine($"***Error The number you enterd is out of range.You enterd {minimum}. Please try again");
                    confirm = false;
                }
                else
                {
                    confirm = true;
                }
            } while (!confirm);

            do
            {
                Console.Write("Enter maximum value in range. ");
                maximum = double.Parse(Console.ReadLine());
                if ((maximum < 0) || (maximum > 100))
                {
                    Console.WriteLine($"***Error The number you enterd is out of range.You enterd {maximum}. Please try again");
                    confirm = false;
                }
                else
                {
                    confirm = true;
                }
            } while (!confirm);

            // this is to call the method getDoubleInRange and also output the percentage inputed.
            value = getDoubleInRange($"Enter a percentage [{minimum}% to {maximum}%]:", minimum, maximum, "*** Value entered must be between 10 nad 30 inclusive.");

            Console.WriteLine($"You entered a percentage of {value:N2}");
        }
    }
}
