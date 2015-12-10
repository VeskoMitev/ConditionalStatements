namespace ConditionalStatements
{
    using System;
    class NumberAsWords
    {
        static string ConvertNumber(int num)
        {
            string result = "";

            if (num == 0) result = "zero";
            if (num/100 > 0)
            {
                result += ConvertNumber(num/100) + " hundred ";
                num %= 100;
            }

            string[] mapStringToTwenty = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tensMapString = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            if (num>0)
            {
                if (result != "") result += "and ";
                if (num < 20)
                {
                    result += mapStringToTwenty[num];
                }
                else
                {
                    result += tensMapString[num/10] + " " + mapStringToTwenty[num%10];
                }
            }
            return result;
        }
        static void Main()
        {
            Console.Write("Enter number(0-999):");
            int inputNumber = Int32.Parse(Console.ReadLine());

           Console.WriteLine( ConvertNumber(inputNumber));



        }
    }
}
