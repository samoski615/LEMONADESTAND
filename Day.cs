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
        public List<string> Days = new List<string> { };
        public string NumberOfDays;
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


        public void DayOfTheWeek()
        {
            List<string> Days = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            switch (HowManyDays())
            {
                case "7":

                    break;
            }

        }
        
               
    }

}


    







//List<DayOfWeek> days = new List<DayOfWeek>();
//days.Add(DayOfWeek.Monday);
//days.Add(DayOfWeek.Tuesday);
//days.Add(DayOfWeek.Wednesday);
//days.Add(DayOfWeek.Thursday);
//days.Add(DayOfWeek.Friday);
//days.Add(DayOfWeek.Saturday);
//days.Add(DayOfWeek.Sunday);

//foreach (var day in days)
//{
//    Console.WriteLine($"today is: {day}");
//}

//DayOfWeek CurrentDay = DateTime.Today.DayOfWeek;
//Console.WriteLine("Today is {0}", CurrentDay);