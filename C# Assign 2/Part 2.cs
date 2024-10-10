using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment2_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lab :15
            //Sum of squares
            //1-user inputed number
            //while loop


            int sum = 0;
            int square;
            Console.WriteLine("Input a Random number till whose sum of squares should be found?");
            int Number = Convert.ToInt32(Console.ReadLine());
            int Temp = Number;
            while (Number > 0)
            {
                square = Number * Number;
                sum = sum + square;
                Number--;

            }
            Console.WriteLine($"The sum of square from 1-{Temp} to {sum}");
            Console.ReadLine();

            //----------------------------------------


            //Lab : 16
            //CountDown Timer
            //10-1,show at each second
            //do-while loop

            int count = 10;
            do
            {
                Console.WriteLine(count);
                count--;
                System.Threading.Thread.Sleep(1000);
            } while (count > 0);
            Console.WriteLine("CountDown Completed");
            Console.ReadLine();
            //-----------------------------------------------------------------

            //Lab : 17
            //Find the multiple of five from list of numbers

            int[] arr = { 2, 5, 7, 20, 3, 4, 7 };

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] % 5 == 0)
                {
                    Console.WriteLine($"{arr[i]} at index {i}");
                    break;
                }
                else
                {
                    continue;
                }
            }
            Console.ReadLine();
            //-----------------------------------------------------


            //Lab 18: Print Non-Multiples of 3
            //1-20

            for (int i = 0; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
            //---------------------------------------------------------


            //Lab : 19
            //Checking for Palindrome
            //while loop
            //number is palindrome

            Console.WriteLine("Enter the number to check if palindrome or not");
            int Number = Convert.ToInt32(Console.ReadLine());
            int Temp = Number;
            int Sum = 0;
            int Remainder = 0;
            while (Number > 0)
            {
                Remainder = Number % 10;
                Sum = (Sum * 10) + Remainder;
                Number = Number / 10;

            }
            if (Temp == Sum)
            {
                Console.WriteLine($"{Temp} is a palindrome");

            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }

            Console.ReadLine();
            //--------------------------------------------------------


            //Lab : 20
            //Average of positive numbers

            int count = 0;
            int sum = 0;
            int Average = 0;
            do
            {
                Console.WriteLine("Enter numbers to calculate average");
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number >= 0)
                {
                    sum = Number + sum;
                    count++;
                    Average = sum / count;
                }
                else
                {
                    break;
                }
            } while (true);

            Console.WriteLine($"Average of {count} numbers is {Average}");
            Console.ReadLine();
            //----------------------------------------------------------


            //Lab: 21
            //Write a C# program to reverse a given number using a do-while loop.
            Console.WriteLine("Enter the number to reverse it");
            int Number = Convert.ToInt32(Console.ReadLine());
            int Temp = Number;
            int Sum = 0;
            int Remainder = 0;
            do
            {

                Remainder = Number % 10;
                Sum = (Sum * 10) + Remainder;
                Number = Number / 10;

            } while (Number > 0);

            Console.WriteLine($"The reverse of the number is {Sum}");
            Console.ReadLine();
            //----------------------------------------------------------------------------


            //Lab : 22
            //Menu-Driven String Operations
            //Switch-Case

            Console.WriteLine("Menu-Driven String Operations");
            Console.WriteLine("Reverse the string........1");
            Console.WriteLine("Convert to uppercase......2");
            Console.WriteLine("Convert to lowercase......3");
            Console.WriteLine("Length of the string......4");

            Console.WriteLine("Choose the required operation number");
            int Number = Convert.ToInt32(Console.ReadLine());

            switch (Number)
            {
                case 1:
                    Console.WriteLine("Enter the number to check if palindrome or not");
                    int Number1 = Convert.ToInt32(Console.ReadLine());
                    int Temp = Number1;
                    int Sum = 0;
                    int Remainder = 0;
                    do
                    {

                        Remainder = Number1 % 10;
                        Sum = (Sum * 10) + Remainder;
                        Number1 = Number1 / 10;

                    } while (Number1 > 0);

                    Console.WriteLine($"The reverse of the number is {Sum}");
                    break;
                case 2:
                    Console.WriteLine("Enter a string to Uppercase it");
                    string Word = Console.ReadLine();

                    Console.WriteLine(Word.ToUpper());
                    break;
                case 3:
                    Console.WriteLine("Enter a string to Lowercase it");
                    string Word1 = Console.ReadLine();

                    Console.WriteLine(Word1.ToLower());
                    break;
                case 4:
                    Console.WriteLine("Enter a string to find its lenght");
                    string Word2 = Console.ReadLine();

                    Console.WriteLine(Word2.Length);
                    break;
                default:
                    Console.WriteLine("Invalid Number");
                    break;


            }
            Console.ReadLine();
            //-------------------------------------------------------------



            //Lab : 23
            //Skip Multiples of 4
            //1-50
            for (int i = 0; i <= 50; i++)
            {
                if (i % 4 == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
            //----------------------------------------------------------------


            //Lab : 24
            //Fibonacci Sequence
            //First 10 numbers
            //For-Loop

            //0 1 1 2 3 5...
            int Previous = -1;
            int result = 1;

            for (int i = 0; i <= 20; i++)
            {
                int Sum = Previous + result;
                Previous = result;
                result = Sum;
                Console.WriteLine(Sum);
            }
            Console.ReadLine();

            //-------------------------------------------------------------


            //Lab : 25
            //Find All Armstrong Numbers
            //1-500
            //while loop

            int num = 1;

            Console.WriteLine("Armstrong numbers between 1 and 500 are:");

            while (num <= 500)
            {
                int temp = num;
                int sum = 0;

                // Calculate the sum of cubes of the digits
                while (temp > 0)
                {
                    int digit = temp % 10;
                    sum += digit * digit * digit;
                    temp /= 10;
                }

                // Check if the sum of cubes is equal to the number
                if (sum == num)
                {
                    Console.WriteLine(num);
                }

                num++;

            }
            Console.ReadLine();

            //---------------------------------------------------------------------------------


            //Lab : 26
            //Lab 26: Menu-Driven Number System Conversion
            //Assignment:
            //Write a C# program to create a menu-driven system for number conversions:
            //1.Binary to Decimal
            //2.Decimal to Binary
            //3.Decimal to Hexadecimal
            //Use a switch-case statement to implement this.

            Console.WriteLine("menu-driven system for number conversions");
            Console.WriteLine("Binary to Decimal.......1");
            Console.WriteLine("Decimal to Binary.......2");
            Console.WriteLine("Decimal to Hexadecimal..3");

            Console.WriteLine("Enter your number");
            int Number = Convert.ToInt32(Console.ReadLine());

            switch (Number)
            {
                case 1:
                    Console.Write("Enter a binary number: ");
                    string binary = Console.ReadLine();

                    int decimalNumber = 0;
                    int baseValue = 1; // 2^0 initially

                    int length = binary.Length;
                    int i = length - 1;

                    // Convert binary to decimal using a while loop
                    while (i >= 0)
                    {
                        if (binary[i] == '1')
                        {
                            decimalNumber += baseValue;
                        }
                        baseValue *= 2; // Move to the next power of 2
                        i--;
                    }

                    Console.WriteLine("Decimal equivalent: " + decimalNumber);
                    break;
                case 2:
                    Console.Write("Enter a decimal number: ");
                    int decimalNumber1 = int.Parse(Console.ReadLine());

                    int num = decimalNumber1;
                    string binary1 = "";

                    // Convert decimal to binary using a while loop
                    while (num > 0)
                    {
                        int remainder = num % 2;
                        binary = remainder + binary1; // Prepend the remainder to the binary string
                        num /= 2;
                    }

                    // Handle the case when the decimal number is 0
                    if (binary1 == "")
                    {
                        binary1 = "0";
                    }

                    Console.WriteLine("Binary equivalent: " + binary1);
                    break;
                case 3:
                    Console.Write("Enter a decimal number: ");
                    int decimalNumber2 = int.Parse(Console.ReadLine());

                    int num2 = decimalNumber2;
                    string hexadecimal = "";
                    char[] hexDigits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

                    // Convert decimal to hexadecimal using a while loop
                    while (num2 > 0)
                    {
                        int remainder = num2 % 16;
                        hexadecimal = hexDigits[remainder] + hexadecimal; // Prepend corresponding hex digit
                        num2 /= 16;
                    }

                    // Handle the case when the decimal number is 0
                    if (hexadecimal == "")
                    {
                        hexadecimal = "0";
                    }

                    Console.WriteLine("Hexadecimal equivalent: " + hexadecimal);
                    break;
            }
            Console.ReadLine();

            //---------------------------------------------------------------------------


            //Lab 28: Count Vowels and Consonants in a String
            //Assignment:
            //Write a C# program to count the number of vowels and consonants in a given string using a for
            //loop.

            Console.Write("Enter a string: ");
            string input = Console.ReadLine().ToLower(); // Convert the input string to lowercase for easy comparison

            int vowelCount = 0, consonantCount = 0;

            // Iterate through each character in the string using a for loop
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                // Check if the character is a vowel
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    vowelCount++;
                }
                // Check if the character is a consonant (a letter that is not a vowel)
                else if (ch >= 'a' && ch <= 'z') // Only count alphabetic characters
                {
                    consonantCount++;
                }
            }

            Console.WriteLine("Number of vowels: " + vowelCount);
            Console.WriteLine("Number of consonants: " + consonantCount);

            Console.ReadLine();
            //--------------------------------------------------------------------------


            //Lab 29: Find Maximum and Minimum
            //Assignment:
            //Write a C# program to find the maximum and minimum of 5 numbers entered by the user using a
            //for loop

            int max, min;

            Console.WriteLine("Enter 5 numbers:");

            // Read the first number to initialize max and min
            int number = int.Parse(Console.ReadLine());
            max = number;
            min = number;

            // Start the loop from the second number
            for (int i = 1; i < 5; i++)
            {
                number = int.Parse(Console.ReadLine());

                // Update max if the current number is larger
                if (number > max)
                {
                    max = number;
                }

                // Update min if the current number is smaller
                if (number < min)
                {
                    min = number;
                }
            }

            Console.WriteLine("Maximum number: " + max);
            Console.WriteLine("Minimum number: " + min);
            Console.ReadLine();

            //------------------------------------------------------


            //Lab 30: Count Digits of a Number
            //Assignment:
            //Write a C# program to count the number of digits in a given number using a while loop

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int count = 0;
            int num = Math.Abs(number); // Use absolute value to handle negative numbers

            Handle the case when the number is 0
            if (num == 0)
                {
                    count = 1;
                }
                else
                {
                    Count digits using a while loop
                   while (num > 0)
                        {
                            num /= 10; // Remove the last digit
                            count++;
                        }
                }

            Console.WriteLine("Number of digits: " + count);
            Console.ReadLine();

            //------------------------------------------------------








            }
    }
}
