using System;
using System.Collections.Generic;
using System.Text;

namespace EverCraft
{
    class CombatArena
    {
        public static int AttackResult { get; set; }
        public static bool AttackHit { get; set; }

        public static void Attack()
        {
            var enemy = new Enemy();
            AttackResult = 11;
            if (AttackResult >= enemy.ArmorClass)
            {
                AttackHit = true;
            }
        }
    }
}

