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
        Inventory inventory;
        
        
        //constructor
        public Store(double PaperCupsPrice, int nCups, double LemonsPrice, int Lemons, double SugarPrice, double IceCubePrice, int nIceCubes)
        {
            this.nCups = 150;
            this.PaperCupsPrice = 3.00;
            this.nLemons = 75;
            this.LemonsPrice = 4.50;
            this.nSugar = 20;
            this.SugarPrice = 2.00;
            this.nIceCubes = 275;
            this.IceCubePrice = 2.50;

            player = new Player();
            inventory = new Inventory();
        }

        public Store()
        {
        }

        //member methods
       
        public void StorePrices()
        {
            Console.WriteLine("Paper Cups: $3.00 for 150 paper cups ");
            Console.WriteLine("Lemons: $4.50 for 75 lemons ");
            Console.WriteLine("Sugar: $2.00 for 20 cups ");
            Console.WriteLine("Ice Cubes: $2.50 for 275 ice cubes ");
            Console.WriteLine("\n");
        }

        public void Resupply()
        {
            Console.WriteLine("What do you need? Enter 'paper cups', 'lemons', 'sugar', or 'ice cubes'");
            string UserInput = Console.ReadLine();
            bool IsInputValid = false;

            while (!IsInputValid)
            {
                string input = UserInput;
                switch (UserInput)
                {
                    case "paper cups":
                        IsInputValid = true;
                        inventory.GetPaperCups();
                        break;

                    case "lemons":
                        IsInputValid = true;
                        inventory.GetLemons();
                        break;

                    case "sugar":
                        IsInputValid = true;
                        inventory.GetSugar();
                        break;

                    case "ice cubes":
                        IsInputValid = true;
                        inventory.GetIceCubes();
                        break;

                    default:
                        return;
                }
                inventory.PlayerTotals();
            }

        }


    }
}
//public void SellCups()
//{

//    Console.WriteLine("Do you need to buy paper cups?", "y/n");
//    Console.ReadLine();  //remember to get the user input to clear--not high priority
//    Console.WriteLine("\n");
//    Console.Write("How many paper cups do you need? You currently have: ");
//    return;
//}

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