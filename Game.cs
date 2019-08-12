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
        Inventory newGameStart;  
        
        //constructor
        public Game()
        {
            UserInterface.DisplayTheRules();
            day = new Day();
            store = new Store();
            player = new Player();
            PlayerWeather = new Weather();
            newGameStart = new Inventory();  //remind myself to set up an Inventory object with parameters? maybe?

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
            
            Console.WriteLine("Show TotalPlayerMoney here");
            Console.WriteLine("show TotalPlayerInventory here");
            store.StorePrices();
            player.PurchaseStuff(store);

            Console.WriteLine("\n");

            Console.WriteLine("this is what I should see after entering a correct value for 'n' when asked to resupply");
        }
    }
}
