
using System;

namespace DrinkMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Drink> AllBeverages = new List<Drink>();
            // List<Drink> AllBeverages;

            Soda soda = new Soda(true);
            Coffee coffee = new Coffee("US", "US");
            Wine wine = new Wine("US", 1995);

            AllBeverages.Add(soda);
            AllBeverages.Add(coffee);
            AllBeverages.Add(wine);


            foreach (Drink item in AllBeverages)
            {
                item.ShowDrink();
            }

            // not working becouse insulation required some attribute from coffe class and soda  class is have different constracter with different attributes required
            // Coffee MyDrink = new Soda();

        }
    }
}