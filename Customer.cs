using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class Customer
    {
        //member variables
        public int PercentChanceOfBuying;
        public int DailyTemp;
        public string ActualCondition;

        List<string> WeatherConditions = new List<string> { "Cloudy", "Sunny", "Rainy", "Humid" };

        //constructor
        public Customer()
        {
            //BuyLemonade();
            DailyWeatherTemp();
            DailyWeatherConditions();
            _ = new Weather();
        }

        //member methods
        public void DailyWeatherTemp()
        {
            Random rng = new Random();
            DailyTemp= rng.Next(60, 91);
        }

        public void DailyWeatherConditions()
        {
            Random rng = new Random();
            int conditions = rng.Next(WeatherConditions.Count);
            ActualCondition = WeatherConditions[conditions];
        }

        //public void BuyLemonade()
        //{
        //    Random rng = new Random();
        //    PercentChanceOfBuying = rng.Next(1, 101);
        //    if ( <= 70 && )
        //    {

        //    }
        //}

        
        
    }


}
