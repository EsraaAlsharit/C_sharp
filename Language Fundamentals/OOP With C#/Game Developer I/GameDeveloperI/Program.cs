
using System;


namespace GameDeveloperI
{
    class Program
    {
        static void Main(string[] args)
        {

            Enemy enemy = new Enemy("Rick");

            Attack Slap = new Attack("Slap", 10);
            Attack Cut = new Attack("Cut", 25);
            Attack Hite = new Attack("Hite", 5);
            Attack attack = new Attack("spiecal attack");

            enemy.addAttack(Slap);
            enemy.addAttack(Cut);
            enemy.addAttack(Hite);

            // enemy.AttackLists.Add(Slap);
            // enemy.AttackLists.Add(Cut);
            // enemy.AttackLists.Add(Hite);
            Console.WriteLine();

            enemy.ShowInfo();
            Console.WriteLine();

            enemy.RandomAttack();
            Console.WriteLine();

            enemy.HealthBar();
        }
    }
}