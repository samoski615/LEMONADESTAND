using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    public class Store 
    {
        //member variables
        int PaperCups;
        int Lemons;
        int Sugar;
        int IceCubes;


        //constructor
        public Store(int PaperCups, int Lemons, int Sugar, int IceCubes)
        {
            this.PaperCups = PaperCups;
            this.Lemons = Lemons;
            this.Sugar = Sugar;
            this.IceCubes = IceCubes;
        }
        //member methods
        public static void resupply()
        {

        }


    }
}
