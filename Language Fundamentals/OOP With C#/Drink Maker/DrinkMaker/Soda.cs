
using System;

namespace DrinkMaker
{
    public class Soda : Drink
    {
        public bool diet;

        public Soda(bool isDiet) : base("Pepsi", "Blue", 19, true, 30)
        {
            diet = isDiet;
        }

        public override void ShowDrink()
        {
            Console.WriteLine($"Name {Name}, Color {Color}, Temperature {Temperature}, had Carbonated {IsCarbonated}, Calories {Calories}, diet version {diet} ");
        }

    }
}