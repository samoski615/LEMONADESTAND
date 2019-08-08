using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
        //member variables
        public int NumberOfDays;

        //constructor



        //member methods 
        public int HowManyDays()
        {
            int n = NumberOfDays;
            Console.WriteLine("How many days would you like to play? Enter 7, 14, or 21");
            Console.ReadLine();
            return n;
        }

    }
}
