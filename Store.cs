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
        Player player;
        //constructor
        public Store()
        {
           player = new Player();

        }
        //member methods
        public static void SellCups()
        {

            Console.WriteLine("Do you need to buy paper cups?", "y/n");
            Console.ReadLine();  //remember to get the user input to clear--not high priority
            Console.WriteLine("\n");
            Console.Write("How many paper cups do you need? You currently have: ");
            return;
        }

        //public static void SellLemons()
        //{
        //    Console.WriteLine("Do you need to buy lemons?", "\n");
        //}

        //public static void SellSugar()
        //{
        //    Console.WriteLine("Do you need to buy sugar?", "\n");
        //}

        //public static void SellIceCubes()
        //{
        //    Console.WriteLine("Do you need to buy ice cubes?", "\n");
        //}

        public static void StorePrices()
        {
            Console.WriteLine("Paper Cups: $3.00 for 150 paper cups ");
            Console.WriteLine("Lemons: $4.50 for 75 lemons ");
            Console.WriteLine("Sugar: $2.00 for 20 cups ");
            Console.WriteLine("Ice Cubes: $2.50 for 275 ice cubes ");
            Console.WriteLine("\n");
        }

        public static string Resupply()
        {
            Console.WriteLine("What do you need? Enter 'Paper Cups', 'Lemons', 'Sugar', or 'Ice Cubes'");
            string UserInput = Console.ReadLine();
            bool IsInputValid = false;

            while (!IsInputValid)
            {
                string input = UserInput;
                switch (UserInput)
                {
                    case "Paper Cups":
                        break;

                    case "Lemons":
                        break;

                    case "Sugar":
                        break;

                    case "Ice Cubes":
                        break;

                    default:
                        return;
                }
            }
            
        }


    }
}
