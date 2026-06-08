using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace One_pawn_with_sword_at_the_board.GameServises
{
    internal class ArmorGenerator
    {
        public static void CreateOne(string[] ANames)
        {
            int index = Random.Shared.Next(ANames.Length);
            string ArmorName = ANames[index];
            Random rnd = new Random();
            int defenseBonus = rnd.Next(1, 5);
            int prise = defenseBonus * 5;
        }
        public void CreateMany(int count)
        {
            for (int i = 0; i < count; i++)
            {
                CreateOne(ANames);
            }
        }

        string[] ANames = { "Шапка магістра", "Темний плащ", "Меч для захисту???", "Деревяшка", "Щит, звичайний щит", "Кубогрудник", "Не темні чоботи", "Цегла Тури", "Повітря", "Книга цілого нічого" };
    }
}
