using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Inventory
    {
        //member variables
        int tPaperCups;
        int tLemons;
        int tSugar;
        int tIceCubes;
        double tMoney;

        //constructor
        public Inventory(int tPaperCups, int tLemons, int tSugar, int tIceCubes, double tMoney)
        {
            this.tPaperCups = 0;
            this.tLemons = 0;
            this.tSugar = 0;
            this.tIceCubes = 0;
            this.tMoney = 0.00;

        }
        public Inventory()
        {

        }

        //member methods
        public void PlayerTotals()
        {
            Console.WriteLine("testing player totals");
        }

        public void GetPaperCups() //send to store for purchasing paper cups
        {

            Console.WriteLine("testing paper cups method");
        }

        public void GetLemons()
        {

        }

        public void GetSugar()
        {

        }

        public void GetIceCubes()
        {

        }


    }
}


//public void TotalPlayerMoney()  //keep track of running total player money
//{



//}

//public void TotalPlayerInventory()  //keep track of running total player inventory
//{

//}