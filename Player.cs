using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
   public class Player
    {
        //member variables
        Inventory inventory;

        //constructor
        public Player()
        {
            inventory = new Inventory();
   
        }



        //member methods
        public void PurchaseStuff(Store store)
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
                        store.Resupply(inventory);              
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
