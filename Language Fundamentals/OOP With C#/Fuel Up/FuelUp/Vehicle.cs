using System;

namespace FuelUp
{
    public abstract class Vehicle
    {

        //Fields
        public string Name;
        public string Color;
        public bool Engine = true;
        public int Passengers = 5;
        private int Miles = 0;

        //Constructors
        public Vehicle(string newName, string newColor)
        {
            Name = newName;
            Color = newColor;
        }
        // public Vehicle(string newName, string newColor, int newPassengers, bool newEngine)
        // {
        //     Name = newName;
        //     Color = newColor;
        //     Passengers = newPassengers;
        //     Engine = newEngine;
        // }


        // method
        public void ShowInfo()
        {
            Console.WriteLine($"Name {Name}, Color {Color}, Passengers {Passengers}, had Engine {Engine}, Miles {Miles}");

        }

        public void Travel(int distance)
        {
            Miles += distance;
        }



    }

}
