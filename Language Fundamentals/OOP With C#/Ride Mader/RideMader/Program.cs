
using System;


namespace RideMader
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vehicle
            //how to link files
            // Vehicle myObj = new Vehicle("Honda", "Gray");
            // Vehicle myObj2 = new Vehicle("Honda", "Red", 2, true);
            // myObj.ShowInfo();

            // myObj2.ShowInfo();
            // myObj2.Travel(100);
            // myObj2.ShowInfo();

            List<Vehicle> Cars = new List<Vehicle>();
            Cars.Add(new Vehicle("Honda", "Gray"));
            Cars.Add(new Vehicle("Honda", "Red", 2, true));
            Cars.Add(new Vehicle("Rollerblades", "White", 8, true));
            Cars.Add(new Vehicle("Mountain Bike", "White", 5, true));

            foreach (Vehicle Car in Cars)
            {
                Car.ShowInfo();
            }
            Console.WriteLine();

            Cars[3].Travel(100);
            Cars[3].ShowInfo();

            //is inaccessible due to its protection level
            // Cars[1].Miles= 350;
            // Cars[1].ShowInfo();

        }
    }
}