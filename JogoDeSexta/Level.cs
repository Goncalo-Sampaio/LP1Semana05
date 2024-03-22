using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoDeSexta
{
    public class Level
    {
        private Toughness toughness;
        private Enemy[] enemyRooms;

        public Level(int rooms, Toughness toughness)
        {
            this.toughness = toughness;
            enemyRooms = new Enemy[rooms];
        }

        public void SetEnemyInRoom(int roomIndex, Enemy enemy)
        {
            enemyRooms[roomIndex] = enemy;
        }

        public Toughness GetToughness()
        {
            return toughness;
        }

        public int GetNumRooms()
        {
            return enemyRooms.Length;
        }

        public int GetNumEnemies()
        {
            int num = 0;
            foreach (Enemy x in enemyRooms)
            {
                if (x != null)
                {
                    num += 1;
                }
            }
            return num;
        }

        public void PrintEnemies()
        {
            for (int i = 0; i < enemyRooms.Length; i++)
            {
                if (enemyRooms[i] != null)
                {
                    Console.WriteLine($"Room {i}: {enemyRooms[i].GetName()}");
                }
            }
        }
    }
}