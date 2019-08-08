using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
   public class Game
    {
       //member variables
       

        //constructor
        public Game()
        {
            //Customer customer = new Customer();
            //Customer.BuyLemonade();
            UserInterface.DisplayTheRules();
            Day day = new Day();
            day.HowManyDays();
            Weather PlayerWeather = new Weather();
            PlayerWeather.GetForecastedCondition();
            Console.WriteLine(PlayerWeather.ForecastedTemp);
            PlayerWeather.GetForecastedTemp();
            Console.WriteLine(PlayerWeather.ForecastedCondition);
            Store store = new Store();
            Console.WriteLine(store.paperCups);
            
        }

        //member methods
        public void RunGame()  //start the game
        {

        }
    }
}
