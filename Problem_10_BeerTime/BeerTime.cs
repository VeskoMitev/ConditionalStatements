namespace Problem_10_BeerTime
{
    using System;

    /*
     * Problem 10.	* Beer Time

     * A beer time is after 1:00 PM and before 3:00 AM. 
     * Write a program that enters a time in format “hh:mm tt” 
     * (an hour in range [01...12], a minute in range [00…59] and AM / PM designator)
     * and prints “beer time” or “non-beer time” according to the definition above or 
     * “invalid time” if the time cannot be parsed. 
     * Note that you may need to learn how to parse dates and times
     */ 

    class BeerTime
    {
        static void Main()
        {  
            TimeSpan inputTime;
            DateTime inputDataTime;
            TimeSpan startBeerTime = DateTime.Parse("01:00 PM").TimeOfDay;
            TimeSpan endBeerTime = DateTime.Parse("3:00 AM").TimeOfDay ;

            Console.Write("Enters a time in format \"hh:mm tt\": ");

            string inputTimeString = Console.ReadLine();

            bool isValidTime = DateTime.TryParse(inputTimeString, out inputDataTime);
            if (isValidTime == false)
            {
                Console.WriteLine("invalid time");
                return;
            }
            inputTime = inputDataTime.TimeOfDay;
           
            if (TimeSpan.Compare(inputTime, startBeerTime) >= 0 && TimeSpan.Compare(inputTime, endBeerTime) > 0)
            {
                Console.WriteLine("beer time");
            }
            else
            {
               Console.WriteLine("non-beer time");
            }
        }
    }
}
