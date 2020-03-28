// Program Name : Technical Support

// Author :        Ndubuisi Christopher Okpala

// Date :          24th March, 2020

// Description :   Rapid App Development for OOSD (CPRG-200-XM5)

//                 This is a technical support program that user could run to assist in
//                 the computer repair. The user will be asked if the ailing computer beeps on start
//                 and if the hard drive spind. The user will be prompt to input either "Y" as yes to the questions
//                 or input "N" as no for one of the questions. Based on the answers provided by the user, he/she will
//                 be instructed on what to do.

using System;

namespace Tech_Support
{
    class Program
    {
        static void Main(string[] args)
        {
            string questionOne;     // this will store the first question that will be asked the user
            string questionTwo;     // this will store the second question that will be asked the user

            // Get answers from the user by prompting them to input either Y or N.

            Console.WriteLine("Please enter Y as Yes or N as No to the following questions");
            Console.Write("Does the computer beep when powered on? ");
            questionOne = Console.ReadLine();
            Console.Write("Does the drive spin when powered on? ");
            questionTwo = Console.ReadLine();

            // Check the answers inputed by the user and out put the right instruction for them

            if (questionOne == "Y")
            {
                if (questionTwo == "Y")
                {
                    Console.WriteLine("Contact Tech Support..");
                }
                else
                {
                    Console.WriteLine("Check drive cables..");
                }
            }
            else
            {
                if (questionTwo == "N")
                {
                    Console.WriteLine("Bring computer to repair center..");
                }
                else
                {
                    Console.WriteLine("Check the speaker contact..");
                }
            }
        }
    }
}
