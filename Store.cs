using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Store 
    {
        double PaperCupsPrice;
        //int tCups;
        double LemonsPrice;
        int nLemons;
        double SugarPrice;
        int nSugar;
        double IceCubePrice;
        int nIceCubes;
        //Store store;
        
        //constructor
        

        
        
        //member methods
       
        public void StorePrices()
        {
            Console.WriteLine("Paper Cups: $3.00 for 150 paper cups ");
            Console.WriteLine("Lemons: $4.50 for 75 lemons ");
            Console.WriteLine("Sugar: $2.00 for 20 cups ");
            Console.WriteLine("Ice Cubes: $2.50 for 275 ice cubes ");
            Console.WriteLine("\n");
        }

        public void Resupply(Inventory inventory)
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
                        inventory.AddPaperCups();
                        break;

                    case "lemons":
                        IsInputValid = true;
                        inventory.AddLemons();
                        break;

                    case "sugar":
                        IsInputValid = true;
                        inventory.AddSugar();
                        break;

                    case "ice cubes":
                        IsInputValid = true;
                        inventory.AddIceCubes();
                        break;

                    default:
                        return;
                }
                inventory.PlayerTotals();
            }

        }

        //public int AddPaperCups()
        //{
        //    int nCups = 150;
        //    int x = 0;
        //    int tCups = x;
        //    tCups = nCups + tCups;
        //    return tCups;
        //}


    }
}

