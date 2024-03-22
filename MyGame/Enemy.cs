using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        public Enemy(string name){
            SetName(name);
            health = 100;
            shield = 0;
        }

        public string GetName(){
            return name;
        }

        public float GetHealth(){
            return health;
        }

        public float GetShield(){
            return shield;
        }

        /// <summary>
        /// Method to set the enemy's name with a max of 8 chars
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name){
            if (name.Length <= 8) {
                this.name = name;
            } else {
                this.name = name.Substring(0, 8);
            }
        }


        public void TakeDamage(float damage){
            shield -= damage;
            if (shield < 0){
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }
    }
}