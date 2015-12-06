namespace ConditionalStatements
{
    using System;
    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.Write("Enter first number:");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter second number:");
            double secondNumber = double.Parse(Console.ReadLine());
            if (firstNumber>secondNumber)
            {
                Console.WriteLine("{0} {1}",secondNumber,firstNumber);
            }
            else
            {
                Console.WriteLine("{0} {1}", firstNumber,secondNumber ); 
            }
        }
    }
}
