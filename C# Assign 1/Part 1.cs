using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignmentDay1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lab 1: Hello, World! and Basic Input / output
            //Assignment:
            //1.Write a program that prints "Hello, World!" to the screen.
            //2.Modify the program to ask the user for their name and greet them with a personalized
            //message.

            Console.WriteLine("\"Hello, World!\"");
            Console.WriteLine("enter name");

            //Ask user for NAME
            string nameUser = Console.ReadLine();
            Console.WriteLine($"Hello {nameUser}");

            Console.ReadLine();

            //------------------------------------------------


            //Lab 2: Input / output with Strings
            //Assignment:
           

            //1.Write a program that asks the user for their full name and age, then prints a message like
            //"Hello, [Name]! You are [Age] years old.”.
            Console.WriteLine("full name");
            string fullName = Console.ReadLine();
            Console.WriteLine("age");
            string age = Console.ReadLine();
            Console.WriteLine($"Hello,  {fullName} ! You are {age} years old.");

            //2.Modify the program to ask for the user's favorite color and include it in the greeting.

            Console.WriteLine("colour");
            string color = Console.ReadLine();
            Console.WriteLine($"The colour you like is {color}");
            Console.ReadLine();

            //--------------------------------------------------

            //Lab 3: Input / output with Arithmetic Operations
            //Assignment:
            //1.Write a program that asks the user to input two numbers and prints the result of their sum,
            //difference, multiplication, and division.
            //2.Modify the program to display a message if the division by zero is attempted.

            Console.WriteLine("First number");
            string One = Console.ReadLine();
            int num1 = Convert.ToInt32(One);
            Console.WriteLine("Second number");
            string Two = Console.ReadLine();
            int num2 = Convert.ToInt32(Two);

            int add = num1 + num2;
            Console.WriteLine("Addition");
            Console.WriteLine(add);

            int sub = num1 - num2;
            Console.WriteLine("Subtraction");
            Console.WriteLine(sub);

            int mul = num1 * num2;
            Console.WriteLine("Multiply");
            Console.WriteLine(mul);

            if (num2 == 0)
            {
                Console.WriteLine("Not valid");
            }
            else
            {
                div = (double)(num1 / num2);
                Console.WriteLine("divide");
                Console.WriteLine(div);
            }

            Console.ReadLine();

            //---------------------------------------------


            //Lab 4: Temperature Conversion
            //Assignment:
            //1.Write a program that takes a temperature in Celsius from the user and converts it to
            //Fahrenheit.
            

            Console.WriteLine("Enter temp in Celsius");
            string cel = Console.ReadLine();


            //2.The formula is: Fahrenheit = (Celsius× 9 / 5) +32.
            int celdub = Convert.ToInt32(cel);
            double Fah = (celdub * 9 / 5) + 32;
            Console.WriteLine("In Fahrenheit=");
            Console.WriteLine(Fah);
            Console.ReadLine();

            //-----------------------------------------------

            //Lab 5: Simple Interest Calculation
            //Assignment:
            //Write a program that calculates the simple interest using the formula: Simple Interest = (P * R *
            //T) / 100, Where P is the principal amount, R is the rate of interest, and T is the time in years.

            
            Console.WriteLine("Simple Interest");
            Console.WriteLine("principle");
            double prin = Double.Parse(Console.ReadLine());
            Console.WriteLine("rate of interest");
            double roi = Double.Parse(Console.ReadLine());
            Console.WriteLine("time");
            double time = Double.Parse(Console.ReadLine());

            double simpleInt = (double)((prin * roi * time) / 100);
            Console.WriteLine($"Simple Interest is {simpleInt}");
            Console.ReadLine();

            //------------------------------------------------------

            //Lab 6: Calculating the Area of a Circle
            //Assignment:
            //Write a program that takes the radius of a circle as input and calculates its area using the
            //formula: Area = π * r * r Where r is the radius, and π is approximately 3.14159.

            Console.WriteLine("enter desired radius");
            double r = Double.Parse(Console.ReadLine());
            const double piValue = 3.14159;
            double area = (double)(piValue * r * r);
            Console.WriteLine($"The area will be {area}");
            Console.ReadLine();

            //-------------------------------------------------------

            //Lab 7: Input / output with Time Calculation
            //Assignment:
            //Write a program that asks the user to input a number of seconds and converts it into hours,
            //minutes, and seconds

            //seconds into hours and min

            Console.WriteLine("Seconds to hours,minutes and seconds");
            Console.WriteLine("Enter Seconds");
            int inpSecond = Convert.ToInt32(Console.ReadLine());
            int Hours = inpSecond / 3600;

            int Rem = inpSecond % 3600;//find remainder to find min
            int Minute = Rem / 60;

            int Seconds = Rem % 60;// find remainder to find seconds
            Console.WriteLine($"{Hours} Hours ,{Minute} Minutes,{Seconds} seconds");
            Console.ReadLine();

            //----------------------------------------------------------


            //Lab 8: String Length and Character Count
            //Assignment:
            //Write a program that takes a string as input and prints the number of characters in the string,
            //excluding spaces.



            ////to find len of a string
            
            Console.WriteLine("To find the len of the string");
            Console.WriteLine("Write the desired string");
            string TestInp = Console.ReadLine();
            //trim any spaces

            string TrimInput = TestInp.Replace(" ", "");
            //find lenght
            int lenght = TrimInput.Length;
            Console.WriteLine($"The lenght will be {lenght}");
            Console.ReadLine();
            //------------------------------------------------------------

            //Lab 9: Body Mass Index(BMI) Calculator
            //Assignment:
            //Write a program to calculate BMI using the formula:
            //BMI = weight / (height * height) where weight is in kilograms and height is in meters.Declare
            //variables weight and height, then calculate and print the BMI.

            //To find bmi
            Console.WriteLine("To find BMI");
            Console.WriteLine("Write desired weight");
            double Weight = Double.Parse(Console.ReadLine()); //write weight

            Console.WriteLine("Write desired height");
            double Height = Double.Parse(Console.ReadLine()); //write Height

            double Bmi = Weight / (Height * Height);//calculation
            Console.WriteLine($"Bmi is equal to {Bmi}");
            Console.ReadLine();

            //---------------------------------------------------------------


            //10
            //init,giving value and getting type

            int a = 3;
            double b = 4.9;
            string c = "test";
            bool d = true;
            char e = 'a';
            float f = 1.30f;

            Console.WriteLine($"a has value {a} and type is {a.GetTypeCode()}");
            Console.WriteLine($"b has value {b} and type is {b.GetTypeCode()}");
            Console.WriteLine($"c has value {c} and type is {c.GetTypeCode()}");
            Console.WriteLine($"d has value {d} and type is {d.GetTypeCode()}");
            Console.WriteLine($"e has value {e} and type is {e.GetTypeCode()}");
            Console.WriteLine($"f has value {f} and type is {f.GetTypeCode()}");
            Console.ReadLine();

            //-------------------------------------------------------------------


            //11

            //Lab 11: Variables and Constants
            //Assignment:
            //Write a program to calculate the area of a circle and a rectangle using variables and constants.
            //Prompt the user to input values

            Console.WriteLine("Area of rectangle and circle");
            const double Pi = 3.14159;
            Console.WriteLine("Write radius");
            double Radius = Double.Parse(Console.ReadLine());

            //Calculating Area
            double Area = (double)(Pi * Radius * Radius);
            Console.WriteLine($"Area of the circle is {Area}");

            //to calculate area of rectangle
            Console.WriteLine("Desired Lenght");
            double lenght = Double.Parse(Console.ReadLine());
            Console.WriteLine("Desired Breadth");

            double breadth = Double.Parse(Console.ReadLine());
            double AreaRectangle = (double)(lenght * breadth);
            Console.WriteLine($"Area of rectangle is {AreaRectangle}");
            Console.ReadLine();
            //------------------------------------------------------------


            //12

            //Lab 12: Using Constants
            //Assignment
            //Declare two constants: const double PI = 3.14159; and const int DAYS_IN_WEEK = 7.Write a
            //program that calculates the circumference of a circle using the formula C = 2 * PI * radius.Print
            //the result along with the number of days in a week.

            Using Constants
            const double PI = 3.14159;
            const int DAYS_IN_WEEK = 7;

            Console.WriteLine("Desired Radius");
            double radius = Double.Parse(Console.ReadLine());
            double Circumference = 2 * PI * radius;

            Console.WriteLine($"Circumference is {Circumference} and no. of days in a week is {DAYS_IN_WEEK}");
            Console.ReadLine();

            //---------------------------------------------------


            //13
            //to convert cm to inches

            Console.WriteLine("Desired Lenght in inch");
            double lenght = Double.Parse(Console.ReadLine());
            double LenIncm = lenght * 2.54; //Conversion
            Console.WriteLine("Desired Breadth in inch");

            double breadth = Double.Parse(Console.ReadLine());
            double BredIncm = breadth * 2.54; //Conversion
            double AreaRectangleInch = (double)(lenght * breadth);
            double AreaRectangleIncm = (double)(LenIncm * BredIncm);

            Console.WriteLine($"Area of rectangle is {AreaRectangleInch} in square-inches and {AreaRectangleIncm} in square-cm");
            Console.ReadLine();

            //-------------------------------------------------


            //14
            //employee’s name, age and monthly salary
            Console.WriteLine("Employee name");
            string EmployeeName = Console.ReadLine();

            Console.WriteLine("Employee age");
            double EmployeeAge = Double.Parse(Console.ReadLine());

            Console.WriteLine("Employee salary");
            double EmployeeSalary = Double.Parse(Console.ReadLine());

            Console.WriteLine($"Employee name is {EmployeeName}, age is {EmployeeAge} and salary is {EmployeeSalary}");
            Console.ReadLine();

            //-----------------------------------------------


            //15
            //Rewrite according to coding standards
            int NumberOne = 5;
            int NumberTwo = 3;
            //add and print the result
            Console.WriteLine($"The result is {NumberOne + NumberTwo}");
            Console.ReadLine();

            //----------------------------------------------

            //16
            //assignment operator to assign(=)
            int a = 3;
            Console.WriteLine(a);
            Console.ReadLine();

            //----------------------------------------------

            //17
            //Math.pov(base,expo value)
            //Finding the power of a number


            Console.WriteLine("Write the number which will be the base");
            double Base = Double.Parse(Console.ReadLine());

            Console.WriteLine("Write the number which will be the exponent");
            double Exponent = Double.Parse(Console.ReadLine());
            //The value will be
            double Value = Math.Pow(Base, Exponent);
            Console.WriteLine($"The Value is {Value}");
            Console.ReadLine();


            //----------------------------------------------
            //18
            //Eligibility to vote

            Console.WriteLine("Check whether you areveligible to vote in India");
            Console.WriteLine("Input your age");
            double Age = Double.Parse(Console.ReadLine());
            Console.WriteLine("Input your nationality");
            string Nationality = Console.ReadLine();

            //Selection statement yo check if eligible

            if ((Nationality.ToLower() == "indian") && (Age >= 18))
            {
                Console.WriteLine("Eligible to vote");
            }
            else
            {
                Console.WriteLine("Not Eligible");
            }
            Console.ReadLine();

            //----------------------------------------------

            //19
            //Eligible for loan or not
            Console.WriteLine("Eligible for loan or not");
            Console.WriteLine("Type in your Age?");

            //input age
            double Age = Double.Parse(Console.ReadLine());
            //input earnings
            Console.WriteLine("Type in your Income per Annum?");
            double Income = Double.Parse(Console.ReadLine());
            //input if you have any existing loans
            Console.WriteLine("Do you have any outstanding loans?");
            string Loan = Console.ReadLine();

            //if condition to find if eligible

            if ((Age >= 21) && (Income >= 30000) && (Loan.ToLower() == "no"))
            {
                Console.WriteLine("Eligible for Loan");
            }
            else
            {
                Console.WriteLine("Not eligible for Loan");
            }
            Console.ReadLine();

            //----------------------------------------------

            //20
            //The person must be between 18 and 35 years old. 
            //The person must have at least 2 years of work experience. 
            //The person must either have a college degree or 5 years of work experience.
            //Eligible for the job or not
            Console.WriteLine("Eligible for job or not");

            //Enter and init variables
            Console.WriteLine("Enter Age:");
            double Age = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter work experience in years");
            double Work_Experience = Double.Parse(Console.ReadLine());

            Console.WriteLine("Do you have a College Degree (Yes/No)");
            string Degree = Console.ReadLine();

            //To check if eligible

            if ((Age >= 18) && (Age <= 35))
            {
                if (((Degree.ToLower() == "yes") && (Work_Experience >= 2)) || (Work_Experience >= 5))
                {
                    Console.WriteLine("Eligible");
                }
                else
                {
                    Console.WriteLine("Not Eligible");
                }

            }
            else
            {
                Console.WriteLine("Not Eligible");
            }
            Console.ReadLine();

            //----------------------------------------------

            //21
            //vowel or consonant
            Console.WriteLine("Vowel Or Consonant ?");
            Console.WriteLine("Write a character");

            //take input character(i/p as string)
            string character = Console.ReadLine();
            if ((character == "a") || (character == "e") || (character == "i") || (character == "o") || (character == "u"))
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
            Console.ReadLine();

            //----------------------------------------------


            //22
            //Positive/Negative/Zero
            Console.WriteLine("To check number is +,- or 0 ?");
            Console.WriteLine("Enter a number");

            //To check which group this number belongs to

            double Number = Double.Parse(Console.ReadLine());
            if (Number > 0)
            {
                Console.WriteLine("Positive Number");
            }
            else if (Number < 0)
            {
                Console.WriteLine("Negative Number");
            }
            else
            {
                Console.WriteLine("Zero is given as Input");
            }

            Console.ReadLine();

            //----------------------------------------------


            //23
            //checks if a number is divisible by both 5 and 11.
            Console.WriteLine("Divisible by both 5 and 11");
            Console.WriteLine("Enter a number");

            double Number = Double.Parse(Console.ReadLine());

            //Selection statements to check if divisible or not

            if ((Number % 5 == 0) && (Number % 11 == 0))
            {
                Console.WriteLine($"{Number} is divisble by both 5 and 11");
            }
            else
            {
                Console.WriteLine($"{Number} not divisible by 5 and 11");
            }

            Console.ReadLine();
            //----------------------------------------------


            //24
            //Calculator
            //2 input number and 1 operator

            Console.WriteLine("First Number?");
            int Number_One = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("OPerator ?");
            string Operator = Console.ReadLine();

            Console.WriteLine("Second Number ?");
            int Number_Two = Convert.ToInt32(Console.ReadLine());

            //Mini Calculater Simulation Code

            if (Operator == "+")
            {
                Console.WriteLine($"The answer is {Number_One + Number_Two}");
            }
            else if (Operator == "-")
            {
                Console.WriteLine($"The answer is {Number_One + Number_Two}");
            }
            else if (Operator == "*")
            {
                Console.WriteLine($"The answer is {Number_One * Number_Two}");
            }
            else
            {
                Console.WriteLine((double)(Number_One / Number_Two));
            }
            Console.ReadLine();

            //----------------------------------------------


            //25
            //Grading System
            Console.WriteLine("Grading System");
            Console.WriteLine("Enter you Marks----- (out of 100)?");
            int Marks = Convert.ToInt32(Console.ReadLine());

            //If the marks are greater than or equal to 90, the grade is 'A'.

            if (Marks >= 90)
            {
                Console.WriteLine("Grade is A");
            }

            //If the marks are between 80 and 89, the grade is 'B'.

            else if ((Marks >= 80) && (Marks <= 89))
            {
                Console.WriteLine("Grade is B");
            }
            //If the marks are between 70 and 79, the grade is 'C'.

            else if ((Marks >= 70) && (Marks <= 79))
            {
                Console.WriteLine("Grade is C");
            }

            //If the marks are between 60 and 69, the grade is 'D'.

            else if ((Marks >= 60) && (Marks <= 69))
            {
                Console.WriteLine("Grade is D");
            }
            else
            {
                Console.WriteLine("Grade is F");
            }
            Console.ReadLine();


            //26
            //a)Swap using 3rd variable
            int a = 0;
            int b = 1;
            int c = b;
            b = a;
            a = c;
            Console.WriteLine($"{a} and {b}");

            Console.ReadLine();

            //b)without 3 variable
            int a = 3;
            int b = 4;

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a is {a}and b is{b}");
            Console.ReadLine();

            //Lab 27: Arithmetic Operations
            //Write a program that takes two numbers as input and performs all arithmetic operations on them
            //(addition, subtraction, multiplication, division, modulus, increment, and decrement).

            //Refer Part 2


        }
    }
}
