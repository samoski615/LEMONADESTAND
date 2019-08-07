using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class Customer
    {
        //member variables
        public int percentChanceOfBuying;
        public int x;
        
        //constructor
        public Customer()
        {
            BuyLemonade();
        }

        //member methods
        public void DailyWeatherTemp()
        {
            Random rng = new Random();
            x= rng.Next(60, 91);
        }

        //public void weatherConditions()
        //{

        //}

        public void BuyLemonade()
        {
            Random rng = new Random();
            percentChanceOfBuying = rng.Next(1, 101);
        }

        
        
    }


}
