using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Store 
    {
        double PaperCupsPrice;
        int nCups;
        double LemonsPrice;
        int nLemons;
        double SugarPrice;
        int nSugar;
        double IceCubePrice;
        int nIceCubes;
        
        //constructor
        public Store()
        {
            Player player = new Player();

        }
        //member methods
        public int SellCups()
        {
            int input = nCups;
            Console.WriteLine("Do you need to buy paper cups?","y/n");
            Console.ReadLine();  //remember to get the user input to clear--not high priority
            return input;

        }

        public static void SellLemons()
        {
            Console.WriteLine("Do you need to buy lemons?", "\n");
        }

        public static void SellSugar()
        {
            Console.WriteLine("Do you need to buy sugar?", "\n");
        }

        public static void SellIceCubes()
        {
            Console.WriteLine("Do you need to buy ice cubes?", "\n");
        }




    }
}
