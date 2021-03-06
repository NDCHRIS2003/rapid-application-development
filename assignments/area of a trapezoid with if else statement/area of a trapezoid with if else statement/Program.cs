﻿// Program Name : Trapezoid Area

// Author :        Ndubuisi Christopher Okpala

// Date :          24th March, 2020

// Description :   Rapid App Development for OOSD (CPRG-200-XM5)

//                 This is to calculate the area of a Trapezoid A = (a + b / 2) * h
//                 This will prompt the user to input a = length of the the parallel sides
//                 b = the lenght of the other parallel side
//                 h = the height, the distance between the parallel sides

using System;

namespace area_of_a_trapezoid_with_if_else_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengthFirstSide;        // this will store the user input for the length of the first parallel side
            double lengthSecondSide;       // thi will store the user inpute for the length of the second parallel side
            double heightDistance;         // this will store the user inpute for the height of the two parallel side
            double areaTrapezoid;          // this will get the calculated value of the area

            // to get inputs from the user and assign them to lengthFirstSide, lengthSecondSide, and heightDistance respectively.

            Console.Write("Please enter the length of the first parallel side..  ");
            lengthFirstSide = double.Parse(Console.ReadLine());
            if (lengthFirstSide <= 0)
            {
                Console.WriteLine($"***Error a side lenght must be a positive value. You entered {lengthFirstSide}");
                return;
            }

            Console.Write("Please enter the length of the second parallel side..  ");
            lengthSecondSide = double.Parse(Console.ReadLine());
            if (lengthSecondSide <= 0)
            {
                Console.WriteLine($"***Error a side lenght must be a positive value. You entered {lengthSecondSide}");
                return;
            }

            Console.Write("Please enter the height of the two parallel side..  ");
            heightDistance = double.Parse(Console.ReadLine());
            if (heightDistance <= 0)
            {
                Console.WriteLine($"***Error the height must be a positive value. You enterd {heightDistance}");
                return;
            }

            // to write the formula of the area of the trapezoid which is A = ((a + b )/ 2) * h and also calculate it.

            areaTrapezoid = ((lengthFirstSide + lengthSecondSide) / 2) * (heightDistance);

            // to outpute the area of the Trapezoid on the console

            Console.WriteLine($"A trapezoid with side's {lengthFirstSide} , and {lengthSecondSide} and height {heightDistance} gives Area of {areaTrapezoid}");

        }
    }
}
