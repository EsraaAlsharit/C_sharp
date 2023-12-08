
using System;


namespace GameDeveloperII
{
    public class Attack
    {

        public string Name;
        public int DamageAmount; //range between 5 and 25

        public Attack(string newName, int newDamage)
        {
            Name = newName;
            if (newDamage >= 5 && newDamage <= 25)
            {
                DamageAmount = newDamage;
            }
            else
            {
                Random rand = new Random();
                int value = rand.Next(5, 25);
                DamageAmount = value;
            }
        }

        public Attack(string newName)
        {
            Name = newName;
            Random rand = new Random();
            int value = rand.Next(5, 25);
            DamageAmount = value;
        }

    }
}