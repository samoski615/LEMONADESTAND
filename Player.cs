using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
   public class Player
    {
        //member variables
        Inventory Inventory;
        Store store;

        //constructor
        public Player()
        {
            store = new Store();
            Inventory inventory = new Inventory();
   
        }



        //member methods
        public void PurchaseStuff()
        {
            Console.WriteLine("Would you like to resupply? y/n");
            string UserInput = Console.ReadLine();
            bool IsInputValid = false;

            while (!IsInputValid)
            {
                string input = UserInput;
                switch (input)
                {
                    case "y":
                        IsInputValid = true;
                        store.Resupply();              
                        break;
                    default:
                        return;   
               }
            }
            
        }

        
        

        public void LemonadeReceipe()
        {
            //used either after purchasing from the store or redirected if a "n" is input into the console from store
            Console.WriteLine("test line for Lemonade receipe method");
        }
    }
}
