namespace ConditionalStatements
{
    using System;

    /* 
     *      Problem 4.	Multiplication Sign

     * Write a program that shows the sign (+, - or 0) 
     * of the product of three real numbers, without 
     * calculating it. Use a sequence of if operators. 
     */ 

    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number:");
            decimal  firstNumber = decimal.Parse(Console.ReadLine());
            Console.Write("Enter second number:");
            decimal secondNumber = decimal.Parse(Console.ReadLine());
            Console.Write("Enter third number:");
            decimal thirdNumber = decimal.Parse(Console.ReadLine());

           
            if(firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
            {
                Console.WriteLine("0");
            }
             else if(firstNumber < 0 || secondNumber < 0 || thirdNumber < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }

        }
    }
}
