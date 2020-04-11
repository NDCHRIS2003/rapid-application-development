// Program Name : Trapezoid Area

// Author :        Ndubuisi Christopher Okpala

// Date :          24th March, 2020

// Description :   Rapid App Development for OOSD (CPRG-200-XM5)

//                 This is to create a program that will generate 5 random numbers between 
//                 a minimum number 1 to maximum number 1000. These random numbers will be
//                 displayed on the console to the user and also the reverse value
//                 of the random number will be shown on the console too.
using System;

namespace reverse_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ARRAY_SIZE   = 5;        // this will store the value of ARRAY_SIZE
            const int RAND_MINIMUM = 1;        // this will store the value of RAND_MINIMUM
            const int RAND_MAXIMUM = 1000;     // this will store the value of RAND_MAXIMUM

            // to create the array myRandomNumbers and initialize it with the array size 'ARRAY_SIZE'
            // and also to create the random constructor

            int[] myRandomNumbers = new int[ARRAY_SIZE];           

            System.Random random = new System.Random();

            // using for loop to create random number of ARRAY_SIZE, output it on the console
            // and also with the reverse output of the array

            for(int i = 0; i < ARRAY_SIZE; i++)
            {
                myRandomNumbers[i] = random.Next(RAND_MINIMUM, RAND_MAXIMUM);
            }

            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                Console.Write($"{myRandomNumbers[i],5}"); 
           
                
            }
            Console.WriteLine();

            for (int i = 0; i < ARRAY_SIZE; i++)
            {
               Array.Reverse(myRandomNumbers);
                Console.Write($"{myRandomNumbers[i],5}");

            }
            Console.WriteLine();
        }
    }
}
