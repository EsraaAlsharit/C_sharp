
using System;


namespace FuelUp
{
    class Car : Vehicle, INeedFuel
    {
        

        public string FuelType { get; set; }
        public  int FuelTotal { get; set; }

        public Car(): base("hondi","gray"){

        }
        public void GiveFuel(int Amount) { 
            Console.WriteLine("Writing to file");
        }

    }
}