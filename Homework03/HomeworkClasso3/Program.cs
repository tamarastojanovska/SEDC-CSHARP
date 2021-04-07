using System;

namespace HomeworkClasso3
{
    class Program
    {
        static void Main(string[] args)
        {
            //CLASS 03 
            //TASK 1
            //   Make a console application called SumOfEven. 
            //Inside it create an array of 6 integers.Get numbers from the input, find and print the sum of the even numbers from the array:


            int[] SumOfEven = new int[6];


            SumOfEven[0] = 4;
            SumOfEven[1] = 3;
            SumOfEven[2] = 7;
            SumOfEven[3] = 3;
            SumOfEven[4] = 2;
            SumOfEven[5] = 8;




            for (int counter = 0; counter < SumOfEven.Length; counter++)

                if (counter % 2 == 0)
                    Console.WriteLine("I even" + counter);
            Console.ReadLine();


            //TASK 2
            //            *Make a new console application called StudentGroup
            //* Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names. 
            //*Get a number from the console between 1 and 2 and print the students from that group in the console.
            //* Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]

            string[] studentsG1 = new string[] { "Bob", "Jill", "Tom", "Pall", "Met" };
            string[] studentsG2 = new string[] { "Kim", "Ros", "Bin", "Katty", "Maggy" };
            foreach (string name in studentsG1)
                Console.WriteLine(studentsG1[2]);
            foreach (string name in studentsG2)
                Console.WriteLine(studentsG1[2]);

Console.WriteLine("Hello World!");
        }
    }
}
