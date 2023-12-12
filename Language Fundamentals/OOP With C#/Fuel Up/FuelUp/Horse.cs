
using System;


namespace FuelUp
{
    class Horse : Vehicle, INeedFuel
    {
        
        public string FuelType { get; set; }
        public  int FuelTotal { get; set; }

        public Horse(): base("speed", "black"){

        }
        public void GiveFuel(int Amount) { }


    }
}