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
            Console.WriteLine("\n");

            Console.WriteLine("Purchase your supplies from the store: ");
            Console.WriteLine("Plan accordingly!");
            Console.WriteLine("\n");
            day.DayOfTheWeek();

            Console.WriteLine("Placeholder method for TotalPlayerMoney");
            Console.WriteLine("Placeholder method for PlayerInventory");

            Console.WriteLine("The forecast for the day is: ");
            PlayerWeather.GetForecastedCondition();
            Console.WriteLine(PlayerWeather.ForecastedTemp);
            PlayerWeather.GetForecastedTemp();
            Console.WriteLine(PlayerWeather.ForecastedCondition);
            store.SellCups();

        }
    }
}
