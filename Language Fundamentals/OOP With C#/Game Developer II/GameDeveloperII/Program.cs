
using System;

namespace GameDeveloperII
{
    class Program
    {
        static void Main(string[] args)
        {


            MeleeFighter Melee = new MeleeFighter("Rick");
            RangedFighter Ranged = new RangedFighter("peter");
            MagicCaster Magic = new MagicCaster("hilda");


            //Melee Fighter
            Attack Punch = new Attack("Punch", 20);
            Attack Kick = new Attack("Kick", 10);
            Attack Tackle = new Attack("Tackle", 25);

            Melee.addAttack(Punch);
            Melee.addAttack(Kick);
            Melee.addAttack(Tackle);

            //ranged fighter
            Attack arrow = new Attack("Shoot an Arrow", 20);
            Attack knife = new Attack("Throw a Knife", 15);

            Ranged.addAttack(arrow);
            Ranged.addAttack(knife);


            //Magic Caster
            Attack Fireball = new Attack("Fireball", 25);
            Attack LightningBolt = new Attack("Lightning Bolt", 20);
            Attack StaffStrike = new Attack("Staff Strike", 10);

            Magic.addAttack(Fireball);
            Magic.addAttack(LightningBolt);
            Magic.addAttack(StaffStrike);


            Melee.PerformAttack(Ranged, Kick);
            Melee.RageMethod(Magic);
            
            Magic.HealthBar();


            Ranged.PerformAttack(Melee, arrow);
            Ranged.DashMethod();
            Ranged.PerformAttack(Melee, arrow);

            Magic.PerformAttack(Melee, Fireball);
            Magic.HealMethod(Ranged);
            Ranged.HealthBar();
            Magic.HealMethod(Magic);
            Magic.HealthBar();

            
        }
    }

}