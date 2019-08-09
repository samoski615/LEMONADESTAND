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
            Store store = new Store();
        }

        //member methods
        public void RunGame()  //start the game
        {
            day.HowManyDays();
            Console.WriteLine("\n");

            Console.WriteLine("Purchase your supplies from the store: ");
            Console.WriteLine("Plan accordingly!");

            Console.WriteLine("\n");

            
            day.DayOfTheWeek();
            Console.WriteLine("\n");

            Console.WriteLine("The forecast for the day is: ");
            PlayerWeather.GetForecastedCondition();
            Console.WriteLine(PlayerWeather.ForecastedTemp);
            PlayerWeather.GetForecastedTemp();
            Console.WriteLine(PlayerWeather.ForecastedCondition);

            Console.WriteLine("\n");
           
            Store.StorePrices();
            Console.WriteLine("Show TotalPlayerMoney here");
            Console.WriteLine("show TotalPlayerInventory here");
            Console.WriteLine("Prompt y/n for resupply");
            Console.WriteLine("if y, redirect to Resupply method");
            Console.WriteLine("if n, redirect to Player class/lemonade Receipe method");
            Console.WriteLine("ask if wants paper cups/lemons/sugar/ice cubes");
            Console.WriteLine("redirect into method to resupply");

        }
    }
}
