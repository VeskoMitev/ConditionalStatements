namespace ConditionalStatements
{
    using System;

    /*Problem 5.	The Biggest of 3 Numbers

     * Write a program that finds the biggest of three numbers
     */ 

    class TheBiggestOf_3_Numbers
    {
        static void Main(string[] args)
        {
            double firstNumber =double.MinValue;

            double result = firstNumber;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter number {0}:",i+1);
              firstNumber = double.Parse(Console.ReadLine());
                if (firstNumber>result)
                {
                    result = firstNumber;
                }
            }
            Console.WriteLine(result);
        }
    }
}
