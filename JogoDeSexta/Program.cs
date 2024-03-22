using System;

namespace JogoDeSexta
{
    public class Program
    {
        private static void Main()
        {
            Level lvl = new Level(121, Toughness.Nightmare);

            lvl.SetEnemyInRoom(0, new Enemy("Prince"));
            lvl.SetEnemyInRoom(120, new Enemy("Chet"));
            lvl.SetEnemyInRoom(4, new Enemy("Axl"));
            lvl.SetEnemyInRoom(18, new Enemy("Faker"));
            lvl.SetEnemyInRoom(58, new Enemy("Out of order"));
            lvl.SetEnemyInRoom(42, new Enemy("Lenon"));

            Console.WriteLine($"Toughness: {lvl.GetToughness()}");

            Console.WriteLine($"Number of rooms: {lvl.GetNumRooms()}");

            Console.WriteLine($"Number of enemies: {lvl.GetNumEnemies()}");

            lvl.PrintEnemies();

            // Este programa mostra o seguinte no ecrã:
            //
            // Difficulty: Nightmare
            // Number of rooms: 121
            // Number of enemies: 6
            // Room 0: Prince
            // Room 4: Axl
            // Room 18: Faker
            // Room 42: Lenon
            // Room 58: Out of order
            // Room 120: Chet
        }
    }
}
