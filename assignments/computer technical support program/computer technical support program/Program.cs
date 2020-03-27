// Program Name : Trapezoid Area

// Author :        Ndubuisi Christopher Okpala

// Date :          24th March, 2020

// Description :   Rapid App Development for OOSD (CPRG-200-XM5)

//                 This is a technical support program that user could run to assist in
//                 the computer repair. The user will be asked if the ailing computer beeps on start
//                 and if the hard drive spind. The user will be prompt to input either "Y" as yes to the questions
//                 or input "N" as no for one of the questions. Based on the answers provided by the user, he/she will
//                 be instructed on what to do.
using System;

namespace computer_technical_support_program
{
    class Program
    {
        static void Main(string[] args)
        {        
            string questionOne;     // this will store the first question that will be asked the user
            string questionTwo;     // this will store the second question that will be asked the user

            // Get questions from the user

            Console.WriteLine("Please enter Y as Yes or N as No to the following questions");            
            Console.Write("Does the computer beep when powered on? ");
            questionOne = Console.ReadLine();
            Console.Write("Does the drive spin when powered on? ");
            questionTwo = Console.ReadLine();
            if (questionOne == "N")
            {
                if (questionTwo == "Y")
                {
                    Console.WriteLine("Contact Tech Support..");
                }
                else
                {
                    Console.WriteLine("Check driver cables..");
                }
            }
            else
            {
                if(questionOne == "Y")
                {
                    Console.WriteLine("Bring computer to repair center..");
                }
                else
                {
                    Console.WriteLine("Check the speaker contacts..");
                }
            }
                





            //if ((questionOne == "Y") && (questionTwo == "Y"))
            // {
            //output instruction for the user

            //    Console.WriteLine("Contact Tech Support");
            //}
            //else
            // {
            //if ((questionOne == "Y") && (questionTwo == "N"))
            //{
            //output instruction for the user

            //  Console.WriteLine("Check drive cables..");
            //}
            // else
            //{
            // if ((questionOne == "N") && (questionTwo == "N"))
            // {
            //output instruction for the user

            //  Console.WriteLine("Bring computer to repair center..");
            //}
            //else
            // {
            //output instruction for the user

            // Console.WriteLine("Check the speaker contacts..");
            //}
            //}
            // }          


        }
    }
}
