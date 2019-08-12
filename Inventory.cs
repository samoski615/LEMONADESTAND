using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Inventory
    {
        public object TotalPaperCups { get; private set; }

       
        int x;

        //constructor
        public Inventory(double tMoney, int tPaperCups, int tLemons, int tSugar, int tIceCubes)
        {
            this.TotalPaperCups = tPaperCups;
            this.tLemons = tLemons;
            this.tSugar = tSugar;
            this.tIceCubes = tIceCubes;
            this.tMoney = tMoney;

        }
        public Inventory(int x)
        {
            this.x = x;
        }

        public Inventory()
        {
        }

        //member methods
        public void PlayerTotals()
        {
            Console.WriteLine("should see player inventory totals here");
        }

        public void GetPaperCups() //send to store for purchasing paper cups
        {
            Inventory PaperCups = new Inventory(x); //pass info into x from store value from purchase x = 150 (x * user input for purchase)
            PaperCups.Equals(TotalPaperCups);
            if (PaperCups == TotalPaperCups)
            {

            }
            Console.WriteLine("get paper cups");
        }

        public void GetLemons()
        {
            Console.WriteLine("get lemons");
        }

        public void GetSugar()
        {
            Console.WriteLine("get sugar");
        }

        public void GetIceCubes()
        {
            Console.WriteLine("get ice cubes");
        }


    }
}


//public void TotalPlayerMoney()  //keep track of running total player money
//{



//}

//public void TotalPlayerInventory()  //keep track of running total player inventory
//{

//}