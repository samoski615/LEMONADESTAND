using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
        //member variables
        public int d;
        public Weather weather;

        //constructor



        //member methods 
        public string HowManyDays()
        {
            Console.WriteLine("How many days would you like to play? Enter 7, 14, or 21", " ");
            string NumberOfDays = Console.ReadLine();
            Console.Write("Great! ");
            Console.Write("You chose to play for ");
            Console.Write(NumberOfDays);
            Console.Write(" days!");
            return NumberOfDays;
        }

        //method for returning day of the week
        public void DayOfTheWeek()
        {
            //for (int d = 1; d < 8; d++)
            //{
            //    Console.WriteLine("Day" + " " + d);
            //}

            Console.WriteLine("Placeholder for DayOftheWeek");
        }

    }
}
