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
        int x;

        //constructor
        public Inventory(int tPaperCups, int tLemons, int tSugar, int tIceCubes, double tMoney)
        {
            this.tPaperCups = 0;
            this.tLemons = 0;
            this.tSugar = 0;
            this.tIceCubes = 0;
            this.tMoney = 0.00;

        }
        public Inventory(int x)
        {
            this.x = 0;
        }

        //member methods
        public void PlayerTotals()
        {
            Console.WriteLine("should see player inventory totals here");
        }

        public void GetPaperCups() //send to store for purchasing paper cups
        {
            Inventory PaperCups = new Inventory(x);
            //create formula for adding purchase to inventory
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