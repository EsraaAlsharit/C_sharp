
using System;


namespace GameDeveloperII
{
    public class MeleeFighter : Enemy
    {



        public MeleeFighter(string newName) : base(newName, 120)
        {


        }

        public void RageMethod(Enemy Target)
        {
            Random rand = new Random();
            // Console.WriteLine(AttackLists.Count);
            int tem = rand.Next(1, AttackLists.Count);

            Console.WriteLine("befor " + AttackLists[tem].Name + " " + AttackLists[tem].DamageAmount);

            Console.WriteLine("after " + AttackLists[tem].Name + " " + (AttackLists[tem].DamageAmount + 10));


            Target.setHealth(
                Target.getHealth() - (AttackLists[tem].DamageAmount + 10)
            );








        }


    }

    // Inside of the Enemy class
}