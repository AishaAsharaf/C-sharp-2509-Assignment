using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignmentDay_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lab 27: Arithmetic Operations
            //Write a program that takes two numbers as input and performs all arithmetic operations on them
            //(addition, subtraction, multiplication, division, modulus, increment, and decrement).

            Console.WriteLine("Enter first number ?");
            int Number_One = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number ?");
            int Number_Two = Convert.ToInt32(Console.ReadLine());

            //ADD
            int Add = Number_One + Number_Two;
            Console.WriteLine($"Number one + Number Two ={Add}");

            //SUBTRACT
            int Sub = Number_One - Number_Two;
            Console.WriteLine($"Number one - Number Two ={Sub}");

            //MULTIPLY
            int Multi = Number_One * Number_Two;
            Console.WriteLine($"Number one * Number Two ={Multi}");

            //REMAINDER
            int Modulus = Number_One % Number_Two;
            Console.WriteLine($"Number one % Number Two ={Modulus}");

            //INCRE AND DECREMENT
            Console.WriteLine($"Increment and decrementing Number one and Number Two = {Number_One += 1} and {Number_Two += 1} and decrement is {Number_One = Number_One - 1} and {Number_Two = Number_Two - 1}");

            //DIVISION
            if (Number_Two != 0)
            {
                Console.WriteLine($"Number_One / Number_Two = {Number_One / Number_Two}");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            //-------------------------------------------------------------

            //28
            //Average of two 3 numbers with 2 decimal places
            Console.WriteLine("Enter First Number");
            double First_Number = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            double Second_Number = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter First Number");
            double Third_Number = Double.Parse(Console.ReadLine());

            //Calculate the Average
            decimal Average_Number = Convert.ToDecimal((First_Number + Second_Number + Third_Number) / 3);
            Console.WriteLine("{0:F2}", Average_Number);
            Console.ReadLine();
            //------------------------------------------------------------------

            //Lab:29
            //Currency Convertion
            //1 usd= 0.85 euro

            Console.WriteLine("Enter currency in USD");
            double Currency = Double.Parse(Console.ReadLine());
            //Conversion
            double Euro = Currency * 0.85;
            Console.WriteLine($"The currency in euro is {Euro}");
            Console.ReadLine();
            //-----------------------------------------------------------------

            //Lab: 30
            //Check if input is within 1 - 100 and if even or odd number

            Console.WriteLine("Enter a number");
            double Number = Double.Parse(Console.ReadLine());

            if ((Number > 1) && (Number < 100))
            {
                if (Number % 2 == 0)
                {
                    Console.WriteLine("Number is even and btw 1-100");
                }
                else
                {
                    Console.WriteLine("nUMBER IS ODD AND BTW 1-100");
                }
            }
            else
            {
                Console.WriteLine("Not btw 1-100");
            }
            Console.ReadLine();
            ///----------------------------------------------------------


            //Lab : 31
            //Check if input is divisible by 3 and 5
            Console.WriteLine("Enter a number");
            double Number = Double.Parse(Console.ReadLine());

            if ((Number % 3 == 0) && (Number % 5 == 0))
            {
                Console.WriteLine("Number is divisible by 3 and 5");
            }
            else
            {
                Console.WriteLine("Number is not divisible by 3 and 5");
            }

            Console.ReadLine();
            //-------------------------------------------------------------


            //Lab : 32
            //Check if year is Leap year or not

            // Input: Get the year from the user
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            // Logic: Check if it's a leap year
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }

            //---------------------------------------------------------------



            //Lab : 33
            //Check whether a number is positive, even and greater than 50
            Console.WriteLine("Enter a number");
            double Number = Double.Parse(Console.ReadLine());
            if (Number > 0)
            {
                if (Number % 2 == 0)
                {
                    if (Number > 50)
                    {
                        Console.WriteLine("Number is positive, even and greater than 50");
                    }
                    else
                    {
                        Console.WriteLine("Number is positive, even and but lesser than 50 or equal");
                    }
                }
                else if (Number > 50)
                {
                    Console.WriteLine("Number is positive but not even but greater than 50");
                }
            }
            else
            {
                Console.WriteLine("Number not positive");
            }
            Console.ReadLine();

            //---------------------------------------------------------------

            //Lab :34
            //Calculate Student Grade
            Console.WriteLine("Student grade calculater");
            Console.WriteLine("Enter first subject marks");
            double Number_One = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second subject marks");
            double Number_Two = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter third subject marks");
            double Number_Third = Double.Parse(Console.ReadLine());

            //1.If the student has passed in all subjects(passing mark is 40 in each subject).
            //2.If the student has passed, check if the average grade is 70 or above.If so, print
            //"Distinction".
            //3.If the student has not passed in any subject, print the number of subjects failed.

            int Passing_Subjects = 0;
            if (Number_One >= 40)
            {
                Passing_Subjects++;
            }
            if (Number_Two >= 40)
            {
                Passing_Subjects++;

            }
            if (Number_Third >= 40)
            {
                Passing_Subjects++;
            }


            if ((Number_One >= 40) && (Number_Two >= 40) && (Number_Third >= 40))
            {
                if ((Number_Third + Number_One + Number_Two) / 3 >= 70)
                {
                    Console.WriteLine("Passed three subjects with average above 70 ,Distinction");
                }
                else
                {
                    Console.WriteLine("Passed all three subjects but not distinction");
                }
            }
            else
            {
                Console.WriteLine($"The number of failed subjects is {3 - Passing_Subjects}");
            }
            Console.ReadLine();

            //---------------------------------------------------------------------


            //Lab : 35
            //Salary and Tax Calculation
            //Input Salary and Age
            Console.WriteLine("Input Your Salary ? ");
            double Salary = Double.Parse(Console.ReadLine());

            Console.WriteLine("Input your Age ?");
            double Age = Double.Parse(Console.ReadLine());

            //1.If the salary is less than $10,000, no tax is applied.
            //2.If the salary is between $10,000 and $50,000, a 10 % tax is applied.
            //3.If the salary is above $50,000, a 20 % tax is applied.
            //4.If the employee is a senior citizen(aged 60 or above), they get an additional tax
            //exemption of $5,000 from their taxable income.
            //5.Your program should
            // Prompt the user to enter their annual salary and age.
            // Use nested if statements to calculate the appropriate tax based on the salary and age.
            // Print the tax amount to be paid.

            if (Age < 60)
            {
                if (Salary < 10000)
                {
                    Console.WriteLine("No tax is applied");
                }
                else if ((10000 <= Salary) && (Salary <= 50000))
                {
                    Console.WriteLine($"The tax needed to be paid is {Salary * 0.10}");
                }
                else if (Salary > 50000)
                {
                    Console.WriteLine($"The tax needed to be paid is {Salary * 0.20}");
                }
            }
            else
            {
                if (Salary < 10000)
                {
                    Console.WriteLine("No tax is applied");
                }
                else if ((10000 <= Salary) && (Salary <= 50000))
                {
                    Console.WriteLine($"The tax needed to be paid is {(Salary * 0.10) - 5000}");
                }
                else if (Salary > 50000)
                {
                    Console.WriteLine($"The tax needed to be paid is {(Salary * 0.20) - 5000}");
                }

            }
            Console.ReadLine();
            //---------------------------------------------------------------------
        }

    }
}
