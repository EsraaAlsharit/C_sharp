
using System;


namespace FuelUp
{
    class Bicycle : Vehicle, INeedFuel
    {

        public string FuelType { get; set; }
        public int FuelTotal { get; set; }

        public Bicycle() : base("maoten","blue")
        {

        }
        public void GiveFuel(int Amount) { }
    }
}