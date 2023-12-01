
using System;


namespace GameDeveloperI
{
    public class Enemy
    {
        public string Name;
        private int Health;
        public List<Attack> AttackLists;


        public Enemy(string newName)
        {
            Name = newName;
            Health = 100;
            AttackLists = new List<Attack>();
        }

        public void addAttack(Attack attack){
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
            Console.WriteLine($"Health: {Health}");
        }

        public void RandomAttack()
        {
            Random rand = new Random();
            // Console.WriteLine(AttackLists.Count);
            int tem = rand.Next(1, AttackLists.Count);
            
            Console.WriteLine(AttackLists[tem].Name);

        }
    }
}