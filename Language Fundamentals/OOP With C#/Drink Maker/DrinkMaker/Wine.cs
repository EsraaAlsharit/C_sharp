
using System;

namespace DrinkMaker
{
    public class Wine : Drink
    {

        public string Region;
        public int Year;

        public Wine(string region, int year) : base("Red wine", "Grean", 19, false, 300)
        {
            Year = year;
            Region = region;
        }

        public override void ShowDrink()
        {
            Console.WriteLine($"Name {Name}, Color {Color}, Temperature {Temperature}, had Carbonated {IsCarbonated}, Calories {Calories}, came from {Region}, it was bottled at {Year}");
        }

    }
}