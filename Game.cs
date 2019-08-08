using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
   public class Game
    {
        //member variables
        Day day;
        Weather PlayerWeather = new Weather();
        Store store = new Store();

        //constructor
        public Game()
        {
            UserInterface.DisplayTheRules();
            day = new Day();
        }

        //member methods
        public void RunGame()  //start the game
        {
            day.HowManyDays();
            Console.WriteLine("Great!");

            //Console.WriteLine("The forecast for the day is: ");
            //PlayerWeather.GetForecastedCondition();
            //Console.WriteLine(PlayerWeather.ForecastedTemp);
            //PlayerWeather.GetForecastedTemp();
            //Console.WriteLine(PlayerWeather.ForecastedCondition);
            Console.WriteLine("\n");
            Console.WriteLine("Purchase your supplies from the store: ");
            Console.WriteLine("Plan accordingly");
            day.DayOfTheWeek();
        }
    }
}
