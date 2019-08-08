using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class Game
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
        }

        //member methods
        public void RunGame()  //start the game
        {

        }
    }
}
