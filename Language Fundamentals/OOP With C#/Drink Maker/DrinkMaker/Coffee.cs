
using System;

namespace DrinkMaker
{
    public class Coffee : Drink
    {

        //roast value (dark, medium, light).
        public string Roast;
        public string TypeOfBeans;

        public Coffee(string roast, string typeOfBeans) : base("Espresso", "brown", 35, true, 30)
        {
            Roast = roast;
            TypeOfBeans = typeOfBeans;
        }

        public override void ShowDrink()
        {
            Console.WriteLine($"Name {Name}, Color {Color}, Temperature {Temperature}, had Carbonated {IsCarbonated}, Calories {Calories}, Roast value {Roast}, type of beans {TypeOfBeans}");
        }
    }
}