using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
   public class Player
    {
        //member variables
        Inventory Inventory;
        

        //constructor
        public Player()
        {
            //Store store = new Store();
            Inventory inventory = new Inventory();
   
        }



        //member methods
        public void PurchaseStuff()
        {
            Console.WriteLine("Would you like to resupply? y/n");
            //if ()
            {

            }
        }

        
        

        public void LemonadeReceipe()
        {
            //used either after purchasing from the store or redirected if a "n" is input into the console from store.Resupply
        }
    }
}
