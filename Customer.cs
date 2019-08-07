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
            //DailyWeatherTemp();
            DailyWeatherConditions();
            ChanceOfBuying();
        }

        //member methods
        public void DailyWeatherTemp(int tempRange1, int tempRange2)
        {
            Random rng = new Random();
            DailyTemp = rng.Next(60, 91);
        }

        public void DailyWeatherConditions()
        {
            Random rng = new Random();
            int Conditions = rng.Next(WeatherConditions.Count);
            ActualConditions = WeatherConditions[Conditions];
        }

        public void PercentageChanceOfBuying(int range1, int range2)
        {
            Random rng = new Random();
            PercentChanceOfBuying = rng.Next(1, 101);
        }

        public static bool BuyLemonade()
        {
            return true;
        }

        public void ChanceOfBuying()
        {

            if (ActualConditions == "Cloudy")
            {
                PercentageChanceOfBuying(33, 66);
            }
            else if (ActualConditions == "Sunny")
            {
                PercentageChanceOfBuying(70, 101);
            }
            else if (ActualConditions == "Rainy")
            {
                PercentageChanceOfBuying(1, 45);
            }
            else if (ActualConditions == "Humid")
            {
                PercentageChanceOfBuying(85, 101);
            }
            else
            {

            }

        }    

            

        




    }


}
