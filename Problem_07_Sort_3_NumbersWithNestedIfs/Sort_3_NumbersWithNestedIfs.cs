namespace ConditionalStatements
{
    using System;
    /*
     * Problem 7.	Sort 3 Numbers with Nested Ifs

     * Write a program that enters 3 real numbers and prints them
     * sorted in descending order. Use nested if statements. 
     * Don’t use arrays and the built-in sorting functionality. 
     */ 

    class Sort_3_NumbersWithNestedIfs
    {
        static void Main(string[] args)
        {
            decimal maxNumber = decimal.MinValue;
            decimal minNumber = decimal.MaxValue;
            decimal midNumber = decimal.MinValue;
            decimal inputValue = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter number {0}:", i + 1);
                inputValue = decimal.Parse(Console.ReadLine());
                bool isMid = true;
                if (inputValue > maxNumber)
                {
                   midNumber = maxNumber;
                   maxNumber = inputValue;
                }
                if (inputValue < minNumber)
                {
                    midNumber = minNumber;
                    minNumber = inputValue;
                }
                if ((inputValue > minNumber && inputValue < maxNumber) || maxNumber == minNumber)
                {
                    midNumber = inputValue;
                }
                
            }
            Console.WriteLine(maxNumber);
            Console.WriteLine(midNumber);
            Console.WriteLine(minNumber);

        }
    }
}
