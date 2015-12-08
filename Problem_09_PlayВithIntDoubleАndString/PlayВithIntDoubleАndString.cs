namespace ConditionalStatements
{

    using System;
        /*
         * Problem 9.	Play with Int, Double and String

         * Write a program that, depending on the user’s choice, inputs an int,
         * double or string variable. If the variable is int or double,
         * the program increases it by one. If the variable is a string,
         * the program appends "*" at the end. Print the result at the console. 
         * Use switch statement. 
         */

   class PlayВithIntDoubleАndString
    {
        static void Main()
        {
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            Console.Write("Please choose a type:");
            ConsoleKeyInfo  enterKey=Console.ReadKey();
            Console.WriteLine();
            switch (enterKey.KeyChar)
            {
                case '1': 
                    Console.Write("Please enter a integer:");
                    Console.WriteLine(Console.ReadLine());
                    break;
                case '2':
                    Console.Write("Please enter a double:");
                    Console.WriteLine(Console.ReadLine());
                    break;
                case '3':
                    Console.Write("Please enter a string:");
                    Console.WriteLine("{0}{1}",Console.ReadLine(),"*");
                   break;
                default:
                    break;

            }
        }
    }
}
