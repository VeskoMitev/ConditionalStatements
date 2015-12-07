namespace ConditionalStatements
{
    using System;
    /*
     * Problem 8.	Digit as Word

     * Write a program that asks for a digit (0-9), and depending on the input, 
     * shows the digit as a word (in English). 
     * Print “not a digit” in case of invalid inut. Use a switch statement
     */ 

    class DigitAsWord
    {
        static void Main()
        {
           Console.Write("Enter integer number:");
            int inputData = Int32.Parse(Console.ReadLine());
            string result = "";
            switch (inputData)
            {
                case 0:
                    result = "zero";
                    break;
                case 1:
                    result = "one";
                    break;
                case 2:
                    result = "two";
                    break;
                case 3:
                    result = "three";
                    break;
                case 4:
                    result = "four";
                    break;
                case 5:
                    result = "five";
                    break;
                case 6:
                    result = "six";
                    break;
                case 7:
                    result = "seven";
                    break;
                case 8:
                    result = "eight";
                    break;
                case 9:
                    result = "nine";
                    break;
                default :
                    result = "not a digit";
                    break;
            }
            Console.WriteLine(result );
        }
    }
}
