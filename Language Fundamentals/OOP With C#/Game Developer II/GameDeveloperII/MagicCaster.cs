
using System;


namespace GameDeveloperII
{
    public class MagicCaster : Enemy
    {



        public MagicCaster(string newName) : base(newName, 80)
        {

        }



        public void HealMethod(Enemy Target)
        {

            Target.setHealth(Target.getHealth() + 40);
        }


    }

    // Inside of the Enemy class
}