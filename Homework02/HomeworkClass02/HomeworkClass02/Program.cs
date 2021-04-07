using System;

namespace HomeworkClass02
{
    class Program
    {
        static void Main(string[] args)
        {
            //# Class 2 Homework 📒
            //## Task 1
            //Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done( +, - , * , / ). Then it returns the result.

            double firstnum;
            double secoundnum;
            double answer;
            string ops;

            Console.WriteLine("Enter first number");
            firstnum = Double.Parse(Console.ReadLine());

            Console.WriteLine("Select operation(+,-,*,/)");
            ops = Console.ReadLine();

            Console.WriteLine("Enter secound number");
            secoundnum = Double.Parse(Console.ReadLine());


            if (ops == "+")
            {
                // do something
            }
            else if (ops == "-")
            {
                // do something else
            }

            Console.WriteLine();

            //## Task 2
            //            Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.
            //*Test Data:
            //            *Enter the First number: 10
            //           * Enter the Second number: 15
            //           * Enter the third number: 20
            //           * Enter the four number: 30
            //         * Expected Output:
            //            *The average of 10, 15, 20 and 30 is: 18

            //double num1 ;
            //double num2 ;
            //double num3 ;
            //double num4 ;


            //Console.WriteLine("Enter first number");
            //num1 = Double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter secound number");
            //num2 = Double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter third number");
            //num3 = Double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter four number");
            //num4 = Double.Parse(Console.ReadLine());

            //double nums = 4;
            //double sum = (num1 + num2 + num3 + num4) / 4;
            //Console.WriteLine(sum);
            Console.WriteLine("Hello World!");
        }
    }
}
