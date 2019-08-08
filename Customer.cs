using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Customer
    {
        //member variables
        public int PercentChanceOfBuying; //create baseline parameters for customer to insert into methods(percent range)
        public bool WillBuyLemonade;

        List<string> WeatherConditions = new List<string> { "Cloudy", "Sunny", "Rainy", "Humid" };

        //constructor
        public Customer()
        {
            //Customer customer = new Customer();
            Weather weather = new Weather();
            weather.GetActualTemp();
            //ChanceOfBuying();
        }

        //member methods
        //public void DailyWeatherTemp(int tempRange1, int tempRange2)
        //{
        //    Random rng = new Random();
        //    DailyTemp = rng.Next(60, 91);
        //}

        //public void DailyWeatherConditions()
        //{
        //    Random rng = new Random();
        //    int Conditions = rng.Next(WeatherConditions.Count);
        //    ActualConditions = WeatherConditions[Conditions];
        //}

        public void PercentageChanceOfBuying(int minRange1, int maxRange2)
        {
            Random rng = new Random();
            PercentChanceOfBuying = rng.Next(1, 101);
        }

        public static bool BuyLemonade()
        {
            return true;
        }

        public void ChanceOfBuying(Weather weather)
        {
            //if (weather.temperature < 50)
            {

            }
           

        }    

            

        




    }


}
//if (weather.GetActualCondition("Cloudy"))
//    if (weather.GetActualTemp(60, 101))
//    {
//    PercentageChanceOfBuying(33, 66);
//}
//else if (ActualConditions == "Sunny")
//{
//    PercentageChanceOfBuying(70, 101);
//}
//else if (ActualConditions == "Rainy")
//{
//    PercentageChanceOfBuying(1, 45);
//}
//else if (ActualConditions == "Humid")
//{
//    PercentageChanceOfBuying(85, 101);
//}
//else
//{

//}