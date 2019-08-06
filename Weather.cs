using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Weather
    {
        //member variables
        int degreesF;
        string forecast;
        public string[] WeatherConditions = { "Cloudy", "Sunny", "Rainy", "Hazy", "Hot and Humid" };

        //constructor
        public Weather()
        {
            int degreesF = 0;
            forecast = null;
            string[] WeatherConditions = { "Cloudy", "Sunny", "Rainy", "Hazy", "Hot and Humid" };
            ActualWeather();
        }
        //member methods
        public void ActualWeather()
        {
            Random rng = new Random();
            string[] WeatherConditions = { "Cloudy", "Sunny", "Rainy", "Hazy", "Hot and Humid" };

            //Generate random indexes for weather conditions
            int mIndex = rng.Next(WeatherConditions.Length);
            Console.WriteLine("The weather conditions for today are {0} ", WeatherConditions[mIndex]);
        }
                   
        public void ActualTemp()
        {
            

       

        }

    }
}
