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
        public string ActualConditions;
        public bool WillBuyLemonade;

        List<string> WeatherConditions = new List<string> { "Cloudy", "Sunny", "Rainy", "Humid" };

        //constructor
        public Customer()
        {
            //_ = new Weather();
            DailyWeatherTemp();
            DailyWeatherConditions();
            ChanceOfBuying();
        }

        //member methods
        public void DailyWeatherTemp()
        {
            Random rng = new Random();
            DailyTemp = rng.Next(60, 91);
        }

        public void DailyWeatherConditions()
        {
            Random rng = new Random();
            int conditions = rng.Next(WeatherConditions.Count);
            ActualConditions = WeatherConditions[conditions];
        }

        public void ChanceOfBuying()
        {
            Random rng = new Random();
            PercentChanceOfBuying = rng.Next(1, 101);
        }

        public static bool BuyLemonade()
        {
            return true;
        }






    }


}
