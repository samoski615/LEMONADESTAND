using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Weather
    {
        //member variables
        int temp;
        string forecast;
        public List<string> WeatherConditions = new List<string> { "Cloudy", "Sunny", "Rainy", "Hazy", "Hot and Humid" };

        //constructor
        public Weather()
        {
            int temp = 0;
            forecast = null;
            string[] WeatherConditions = { "Cloudy", "Sunny", "Rainy", "Hazy", "Hot and Humid" };
            ActualWeather();

        }
        //member methods
        public void ActualWeather()
        {
            Random rng = new Random();
            string[] WeatherConditions = { "Cloudy", "Sunny", "Rainy", "Hazy", "Hot and Humid" };
            int mIndex = rng.Next(WeatherConditions.Length);
        }

        public int ActualTemp()
        {
            Random temp = new Random();
            Console.WriteLine(temp.Next(60, 80));
            return ActualTemp();
        }
    }

}

