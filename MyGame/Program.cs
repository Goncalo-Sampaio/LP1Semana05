using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int nOfEnemies = int.Parse(args[0]);
            Enemy[] enemies = new Enemy[nOfEnemies];

            for (int i = 0; i < nOfEnemies; i++){
                Console.Write($"Nome do inimigo {i + 1}: ");
                string name = Console.ReadLine();
                Enemy enemy = new Enemy(name);
                enemies[i] = enemy;
            }

            foreach(Enemy x in enemies){
                string name = x.GetName();
                float health = x.GetHealth();
                float shield = x.GetShield();
                Console.WriteLine($"{name} {health} {shield}");
            }
        }
    }
}
