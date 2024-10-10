using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lab 1: Multiplication table of a given number
            //Assignment:
            //Write a C# program to print the multiplication table of a given number using the for loop.

            Console.WriteLine("Multiplation Table of which Number ?");
            int Number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{Number}*{i}={Number * i}");
            }
            Console.ReadLine();

            //-----------------

            //Lab: 2 Display a right - angled triangle
            //Assignment:
            //Write a C# program to display a right-angled triangle pattern using nested for loops.
            Console.WriteLine("Number of rows needed?");
            int row = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //-------------------------------------------------------------

            //Lab 3: Sum of all even numbers between 1 and 100
            //Assignment:
            //Write a C# program to calculate the sum of all even numbers between 1 and 100 using a while
            //loop.
            int sum = 0;
            int i = 1;
            while (i <= 100)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;

                }
                i++;

            }
            Console.WriteLine($"The sum is {sum}");
            Console.ReadLine();

            //-----------------------------------------
            //Lab 4: Multiplication table from 1 to 5
            //Assignment:
            //Write a C# program to print a multiplication table from 1 to 5 using nested while loops.
            int i = 1;
            while (i <= 5)
            {
                int j = 1;
                while (j <= 10)
                {
                    Console.WriteLine($"{i}*{j}={i * j}");
                    j++;
                }
                Console.WriteLine();
                i++;

            }
            Console.ReadLine();
            //----------------------------------------



            //---------------------------
            //Lab 5: Print Positive Number
            //Assignment:
            //Write a C# program to keep asking the user to enter a positive number and print it. The program
            //should stop when the user enters a negative number.

            bool Value = true;
            while (Value)
            {
                Console.WriteLine("Enter a positive number");
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number >= 0)
                {
                    continue;
                }
                else
                {
                    Value = false;
                    break;

                }
            }
            Console.ReadLine();

            //----------------------------------------
            //Lab 6: Create Menu Driven Calculator
            //Assignment:
            //Write a C# program to create a basic menu-driven calculator using nested do-while loops. The
            //calculator should continue to ask the user for two numbers and an operation(+, -, *, /) until the
            //user chooses to exit.

            string Exit = "Yes";
            double result = 0;

            Console.WriteLine("Do you want to exit?");
            string Response = Console.ReadLine();
            if (Response == Exit.ToLower())
            {
                Console.WriteLine("Exited from program");
            }
            else
            {
                do
                {
                    Console.WriteLine("Enter first Number?");
                    double Number_One = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Operater(+,-,/*)");
                    string OPerater = Console.ReadLine();
                    Console.WriteLine("Enter Second Number ?");
                    double Number_Two = Double.Parse(Console.ReadLine());
                    if (OPerater == "+")
                    {
                        Console.WriteLine($"{Number_One}+{Number_Two}={Number_Two + Number_One}");
                    }
                    else if (OPerater == "-")
                    {
                        Console.WriteLine($"{Number_One}-{Number_Two}={Number_Two - Number_One}");
                    }
                    else if (OPerater == "*")
                    {
                        Console.WriteLine($"{Number_One}*{Number_Two}={Number_Two * Number_One}");
                    }
                    else if (OPerater == "/")
                    {
                        if (Number_Two != 0)
                        {
                            Console.WriteLine($"{Number_One}/{Number_Two}={Number_One / Number_Two}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid");
                        }
                    }
                    Console.WriteLine("Do you want to exit?----(Yes/No)");
                    string Response_2 = Console.ReadLine();
                    if (Response_2.ToLower() == "Yes")
                    {
                        Console.WriteLine("Exited from program");
                        break;
                    }




                }
                while (Exit.ToLower() != Response);



            }


            Console.ReadLine();


            //------------------------------------------------------------

            //Lab 7: Print All Numbers From 1 to 100
            //Assignment:
            //Write a C# program to print all numbers from 1 to 100. Use the continue statement to skip
            //numbers that are divisible by 3, and use the break statement to stop the loop if the number
            //exceeds 50.

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                else if (i > 50)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

            //----------------------------------------------------------
            //Lab 8: Sum of Odd Numbers
            //Assignment:
            //Write a C# program to calculate the sum of all odd numbers between 1 and 100 using a for loop.

            int sum = 0;
            int i = 1;
            while (i <= 100)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;

                }
                i++;

            }
            Console.WriteLine($"The sum is {sum}");
            Console.ReadLine();

            //-----------------------------------
            //Lab 9: Factorial Calculation
            //Assignment:
            //Write a C# program to calculate the factorial of a given number using a while loop.
            Console.WriteLine("Number for which factorial should be found?");
            int Number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            while (Number >= 1)
            {
                factorial = factorial * Number;
                Number--;
            }
            Console.WriteLine(factorial);
            Console.ReadLine();

            //-------------------------------------------
            //Lab 10
            //Assignment:
            //Write a C# program to print a number pyramid using a nested while loop. Example for 5 rows:
            //1
            //22
            //333
            //4444
            //55555
            Console.WriteLine("enter no.of rows?");
            int Number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadLine();

            //---------------------------------------
            //lab 11
            //Generate Random Numbers


            do
            {
                Random number = new Random();
                int number_one = number.Next(1, 100);
                bool result = true;
                while (result == true)
                {
                    Console.WriteLine("Random Number Guess Game");
                    Console.WriteLine("Your Guess ?");
                    int User_Number = Convert.ToInt32(Console.ReadLine());

                    if (number_one > User_Number)
                    {
                        Console.WriteLine("Too less,take a guess again");
                        continue;

                    }
                    else if (number_one < User_Number)
                    {
                        Console.WriteLine("Too High, take a guess again");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Congrats");
                        result = false;
                        break;
                    }
                }
            } while (true);


            Console.ReadLine();

            //--------
            //lab 12
            //Simple Calculator
            //Assignment:
            //Write a C# program to create a simple calculator using a switch-case statement.

            Console.WriteLine("Simple Calculator");
            Console.WriteLine("First Number");
            int Number_One = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Operator to be used");
            string operater = Console.ReadLine();
            Console.WriteLine("First Number");
            int Number_Two = Convert.ToInt32(Console.ReadLine());



            switch (operater)
            {
                case "+":
                    Console.WriteLine($"{Number_One}+{Number_Two}={Number_One + Number_One}");
                    break;
                case "-":
                    Console.WriteLine($"{Number_One}-{Number_Two}={Number_One - Number_Two}");

                case "*":
                    Console.WriteLine($"{Number_One}*{Number_Two}={Number_One * Number_Two}");
                    break;
                case "/":
                    if (Number_Two == 0)
                    {
                        Console.WriteLine("Invalid Input");
                    }
                    else
                    {
                        Console.WriteLine($"{Number_One}-{Number_Two}={Number_One / Number_Two}");

                    }
                    break;
            }
            Console.ReadLine();

            //----------------------------------------
            //13
            //Sum of digits
            Console.WriteLine("Sum of digits written");
            Console.WriteLine("Write the digit");
            int Number = Convert.ToInt32(Console.ReadLine());
            int Sum = 0;
            int Number_rem_10 = 0;
            do
            {
                Number_rem_10 = Number % 10;
                Sum = Sum + Number_rem_10;
                Number = Number / 10;
            }
            while (Number > 0);
            Console.WriteLine(Sum);
            Console.ReadLine();

            //----------------------------------
            //14
            //Finding the Largest Number
            Console.WriteLine("Largest Number");
            Console.WriteLine("Write 10 Numbers");

            int Large = 0;
            int count = 10;
            do
            {
                int Number = Convert.ToInt32(Console.ReadLine());

                if (Number > Large)
                {
                    Large = Number;
                    Console.WriteLine($"Largest number is {Large}");
                    count--;
                }
                else
                {
                    count--;
                    continue;

                }

                if (count == 0)
                {
                    Console.WriteLine($"Largest number in 10 numbers is {Large}");
                    Console.WriteLine("Program Stopped");
                    break;
                }

            } while (count > 0);


            Console.ReadLine();


            ////-------------------------------------------------------
        }
    }
}
