
using System;


namespace FuelUp
{
    class Program
    {
        static void Main(string[] args)
        {

            Bicycle bicycle = new Bicycle();
            Car car = new Car();
            Horse horse = new Horse();

            //Cannot create an instance of the abstract type or interface 'Vehicle'
            // Vehicle vehicle=new Vehicle();

            List<Vehicle> vehicles = new List<Vehicle>();

            List<INeedFuel> INeedFuels = new List<INeedFuel>();

        }
    }
}