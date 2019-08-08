using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
        //member variables
        public int NumberOfDays;
        public int d;
        public Weather weather;

        //constructor



        //member methods 
        public int HowManyDays()
        {
            int n = NumberOfDays;
            Console.WriteLine("How many days would you like to play? Enter 7, 14, or 21", " ");
            Console.ReadLine();
            return n;
        }

        //method for returning day of the week
        public void DayOfTheWeek()
        {
            //for (int d = 1; d < 8; d++)
            //{
            //        Console.WriteLine("Day" + " " + d);
            //}

            Console.WriteLine("Placeholder for DayOftheWeek");
        }

    }
}
