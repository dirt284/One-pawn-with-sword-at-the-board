using System;
using System.Collections.Generic;
using System.Text;

namespace One_pawn_with_sword_at_the_board.player
{
  
    internal class player
    {
        public int health;
        public int maxHealth;
        public int damage;
        public int expiriense;
        public int expirienseNeed;
        public int money;
        public int level;
        public int weaponId;
        public int armorId;
        public int magic;
        public int defense;
        public int dise;
        public int diseCD;
        public static int Attack(int damage, int enemyHealth, int damageBonus)
        {
            return enemyHealth = enemyHealth - damage - damageBonus;
        }
        public static int getAttack(int enemyDamage, int health, int defense)
        {
            return health = health + defense - enemyDamage;
        }
        public static int LVup(int expiriense, int health, int defense, int damage)
        {
            return health = health + 10;
            return defense = defense + 2;
            return damage = damage + 1;
            return expiriense = expiriense - 100;
        }
    }
}
  