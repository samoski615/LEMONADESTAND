using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Weather
    {
        //member variables
        int ForecastedTemp;
        string ForecastedCondition;
        int ActualTemp;
        string ActualCondition;

        List<string> WeatherConditions = new List<string> { "Cloudy", "Sunny", "Rainy", "Humid" };

        //constructor
        public Weather()
        {
            GetForecastedTemp();
            GetForecastedCondition();
            GetActualTemp();
            GetActualCondition();
        }
        //member methods
        public void GetForecastedCondition()
        {
            Random rng = new Random();
            int conditions = rng.Next(WeatherConditions.Count);
            ForecastedCondition = WeatherConditions[conditions];
        }

        public void GetForecastedTemp()
        {
            Random rng = new Random();
            ForecastedTemp = rng.Next(60,91);
        }

        public void GetActualTemp()
        {
            Random rng = new Random();
            ActualTemp = rng.Next(ForecastedTemp - 5, ForecastedTemp + 6);
        }

        public void GetActualCondition()
        {
            Random rng = new Random();
            int conditions = rng.Next(WeatherConditions.Count);
            ActualCondition = WeatherConditions[conditions];
        }

    }

}

