using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
        //member variables
        //public int d;
        public Weather weather;

        //constructor



        //member methods 
        public string HowManyDays()  //method for player to indicate how many days they want to play
        {  
            Console.WriteLine("How many days would you like to play? Enter 7, 14, or 21", " ");
            string NumberOfDays = Console.ReadLine();
            bool IsInputValid = false;

            while (!IsInputValid)
            {
                string input = NumberOfDays;
                switch (input)
                {
                    case "7":
                        IsInputValid = true;
                        Console.Write("Great! ");
                        Console.Write("You chose to play for ");
                        Console.Write(NumberOfDays);
                        Console.Write(" days!");
                        break;

                    case "14":
                        IsInputValid = true;
                        Console.Write("Great! ");
                        Console.Write("You chose to play for ");
                        Console.Write(NumberOfDays);
                        Console.Write(" days!");
                        break;

                    case "21":
                        IsInputValid = true;
                        Console.Write("Great! ");
                        Console.Write("You chose to play for ");
                        Console.Write(NumberOfDays);
                        Console.Write(" days!");
                        break;

                    default:
                        return HowManyDays();
                }
            }
            return NumberOfDays;
        }

        
        //public void DayOfTheWeek()  //method for returning day of the week
        //{
            

        //    switch (switch_on)
        //    {
        //        default:
        //    }

             
        //}

    }
}
