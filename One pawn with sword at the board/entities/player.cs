using System;
using System.Collections.Generic;
using System.Text;

namespace One_pawn_with_sword_at_the_board.Player
{
  
    internal class Player
    {
        public int health;
        public int maxHealth;
        public int damage;
        public int expirience;
        public int expirienceNeed;
        public int money;
        public int level;
        public int weaponId;
        public int armorId;
        public int magic;
        public int defense;
        public int dise;
        public int diseCD;
        public int heal;
        public static int Attack(int damage, int enemyHealth, int damageBonus)
        {
            return enemyHealth = enemyHealth - damage - damageBonus;
        }
        public static int getAttack(int enemyDamage, int health, int defense)
        {
            return health = health + defense - enemyDamage;
        }
        public void addExpirience(int value)
        {
            this.expirience += value;

            while (this.expirience > this.expirienceNeed)
            {
                levelUp();
                this.expirience -= this.expirienceNeed;
                this.expirienceNeed = this.expirienceNeed * 2;
            }
        }

        private void levelUp()
        {
            this.level += 1;

            damage += 1;
            health += 2;
            defense += 1;
            heal += 3;
            magic += 1;
        }
        public static int Heal( int health, int heal)
        {
            return health = health + heal;
        }
    }
}
  