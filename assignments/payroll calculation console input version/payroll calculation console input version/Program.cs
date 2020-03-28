// Program Name : Payroll Calculation Program

// Author :        Ndubuisi Christopher Okpala

// Date :          27th March, 2020

// Description :   Rapid App Development for OOSD (CPRG-200-XM5)

//                 This is to write a program that will prompt the user to provide employee name, the number of hours worked 
//                 by the employee, their rate of pay and the percentage of their gross pay that is deducted for benefit, income
//                 etc. These information provided by the user will be used to compute and output the following in organized manner
//                 Gross pay, Dollar amount of deduction and the Net pay.
using System;

namespace payroll_calculation_console_input_version
{
    class Program
    {
        static void Main(string[] args)
        {
            // decimal is preferred ahead of float and double because it gives 100 percent accuracy as
            // the design involves monetary calculation and it is preferred in financial applications.

            string  employeeName;                    // this will store the employee's name
            decimal numberOfHours;                   // this will store the number of hours worked by employee
            decimal rateOfPay;                       // this will store the rate of pay by the employee
            decimal percentageDeduction;             // this will store the percentage deduction
            decimal grossPay;                        // this will store the gross pay of the employee
            decimal dollarAmountDeducted;            // this will store the dollar amount deducted from the employee's pay
            decimal netPay;                          // this will store the net pay of the employee

            // prompt the user to provide the following details.
            Console.WriteLine("Please provide the following details");

            // to prompt the user to provide the following employee's name, number of hours worked by the employee,
            // the rate of pay of the employee, percentage deduction of the employee.

            Console.Write("What is the employee's full name? ");
            employeeName = Console.ReadLine();

            Console.Write("What is the number of hours worked by the employee? ");
            numberOfHours = decimal.Parse(Console.ReadLine());

            Console.Write("What is the rate of pay of the employee? ");
            rateOfPay = decimal.Parse(Console.ReadLine());

            Console.Write("What is the percentage deduction of the employee? ");
            percentageDeduction = decimal.Parse(Console.ReadLine()) / 100;

            // to calculate the employee gross pay, the dollar amount deduction and the net pay
            grossPay             = numberOfHours * rateOfPay;
            dollarAmountDeducted = grossPay * percentageDeduction;
            netPay               = grossPay - dollarAmountDeducted;

            // to print out the employee's name, gross pay, dollar amount deducted and net pay in an organized form

            Console.WriteLine("\n********************Employee Pay Slip*******************\n");
            Console.WriteLine($"Employee's Name:    {employeeName}");
            Console.WriteLine($"Hours worked:       {numberOfHours:N2} hours at ${rateOfPay:N2} per hour");
            Console.WriteLine($"Gross Pay:          ${grossPay:N2}");
            Console.WriteLine($"Deductions:         ${dollarAmountDeducted:N2}");
            Console.WriteLine($"Net Pay:            ${netPay:N2}");
            Console.WriteLine("\n*********************************************************\n");

            // The above output can also be printed out using the below line of codes when commented out.

            //Console.WriteLine($"\n Employee Pay Slip\n*************************\n Employee's Name:   {employeeName}\n Hours worked:      ${numberOfHours:N2} hours at ${rateOfPay:N2} per hour \n " +
            //              $"Gross Pay:         ${grossPay:N2}\n Deductions:        ${dollarAmountDeducted:N2}\n Net Pay:           ${netPay:N2}\n *************************");
        }
    }
}
