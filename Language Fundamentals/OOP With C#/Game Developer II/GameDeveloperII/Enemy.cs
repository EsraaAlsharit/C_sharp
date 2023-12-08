
using System;


namespace GameDeveloperII
{
    public class Enemy
    {
        public string Name;
        private int Health;
        public List<Attack> AttackLists;

        public Enemy(string newName, int newHealth= 100)
        {
            Name = newName;
            Health = newHealth;
            AttackLists = new List<Attack>();
        }

        public void addAttack(Attack attack)
        {
            AttackLists.Add(attack);
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name {Name}, Health {Health}, Attack List :");
            foreach (Attack AttackList in AttackLists)
            {
                Console.WriteLine($" Attack {AttackList.Name}");
            }
        }
        public void HealthBar()
        {
            Console.WriteLine($"{Name} Health: {Health}");
        }

        public void setHealth(int newHealth){
            Health=newHealth;
        }
        public int getHealth(){
            return Health;
        }

        public virtual void RandomAttack()
        {
            Random rand = new Random();
            // Console.WriteLine(AttackLists.Count);
            int tem = rand.Next(1, AttackLists.Count);

            Console.WriteLine(AttackLists[tem].Name);

        }

        public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
        {
           

            Target.Health -= ChosenAttack.DamageAmount;
            Console.WriteLine(
                $"{Name} attacks {Target.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!"
                );
        }

    }
}


