namespace ConditionalStatements
{
    using System;

    /*
     * Problem 6.	The Biggest of Five Numbers

     * Write a program that finds the biggest of five numbers by using only five if statements. 
     */


    class TheBiggestOfFiveNumbers 
    {
        static void Main(string[] args)
        {
            double inputNumber = double.MinValue;

            double result = inputNumber;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter number {0}:", i + 1);
                inputNumber = double.Parse(Console.ReadLine());
                if (inputNumber > result)
                {
                    result = inputNumber;
                }
            }
            Console.WriteLine(result);
        }
    }
}
