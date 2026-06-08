using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace One_pawn_with_sword_at_the_board.GameServises
{
    internal class WeaponGenerator
    {
        public static void CreateOne(string[] WNames)
        {
        int index = Random.Shared.Next(WNames.Length);
        string WeaponName = WNames[index];
        Random rnd = new Random();
        int damageBonus = rnd.Next(1, 5);
        int prise = damageBonus * 5;
        }
        public void CreateMany(int count)
        {
            for (int i = 0; i < count; i++)
            {
                CreateOne(WNames);
            }
        }

        string[] WNames = { "Гострий камінець", "Темний молот", "Щит для атаки???", "Думеранг","Меч, звичайний меч", "Швидкоспис", "Не темний лук", "Осколок Ферзя", "Повітря", "Посох цілого нічого" };
    }
}
