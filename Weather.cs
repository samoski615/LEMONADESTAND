using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Weather
    {
        //member variables
        int forecastedTemp;
        string forecastedCondition;
        int actualTemp;
        string actualCondition;

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
            forecastedCondition = WeatherConditions[conditions];
        }

        public void GetForecastedTemp()
        {
            Random rng = new Random();
            forecastedTemp = rng.Next(60,91);
        }

        public void GetActualTemp()
        {
            Random rng = new Random();
            actualTemp = rng.Next(forecastedTemp - 5, forecastedTemp + 6);
        }

        public void GetActualCondition()
        {
            Random rng = new Random();
            int conditions = rng.Next(WeatherConditions.Count);
            actualCondition = WeatherConditions[conditions];
        }

    }

}

