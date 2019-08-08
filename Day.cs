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
            Console.WriteLine("How many days would you like to play? Enter 7, 14, or 21");
            Console.ReadLine();
            return n;
        }

        //method for returning day of the week
        public void DayOfTheWeek()
        {
            for (int d = 1; d < 8; d++)
            {
                if (d == 1)
                {
                    Console.WriteLine("Day" + " " + d);
                }
                else if (d == 2)
                {
                    Console.WriteLine("Day" + " " + d);
                }
            }
        }
    }
}
