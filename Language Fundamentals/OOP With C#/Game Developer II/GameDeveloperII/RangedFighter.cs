
using System;


namespace GameDeveloperII
{
    public class RangedFighter : Enemy
    {
        public int Distance;



        public RangedFighter(string newName) : base(newName)
        {
            Distance = 5;

        }



        public override void PerformAttack(Enemy Target, Attack ChosenAttack)
        {
            if (Distance > 10)
            {
                Target.setHealth(
                Target.getHealth() - ChosenAttack.DamageAmount
            );


                Console.WriteLine(
                $"{Name} attacks {Target.Name}, dealing {ChosenAttack.DamageAmount} damage"
                );
            }
            else
            {
                Console.WriteLine("can't attack the distance is too close");
            }

        }


        public void DashMethod()
        {
            Distance = 20;
        }

    }

    // Inside of the Enemy class
}