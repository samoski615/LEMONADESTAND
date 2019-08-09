using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
   public class Game
    {
        //member variables
        Day day;
        Weather PlayerWeather;
        Store store;
        Player player;

        //constructor
        public Game()
        {
            UserInterface.DisplayTheRules();
            day = new Day();
            store = new Store();
            player = new Player();
           PlayerWeather = new Weather();
        }

        //member methods
        public void RunGame()  //start the game
        {
            day.HowManyDays();
            Console.WriteLine("\n");

            Console.WriteLine("Purchase your supplies from the store: ");
            Console.WriteLine("Plan accordingly!");

            Console.WriteLine("\n");

            
            //day.DayOfTheWeek();
            Console.WriteLine("\n");

            Console.WriteLine("The forecast for the day is: ");
            PlayerWeather.GetForecastedCondition();
            Console.WriteLine(PlayerWeather.ForecastedTemp);
            PlayerWeather.GetForecastedTemp();
            Console.WriteLine(PlayerWeather.ForecastedCondition);

            Console.WriteLine("\n");
           
            store.StorePrices();
            Console.WriteLine("Show TotalPlayerMoney here");
            Console.WriteLine("show TotalPlayerInventory here");
            player.PurchaseStuff(store);

            Console.WriteLine("\n");

            Console.WriteLine("if n, redirect to Player class/lemonade Receipe method");
            player.LemonadeReceipe();

        }
    }
}
