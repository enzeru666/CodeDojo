using System;
using System.Collections.Generic;
using System.Text;

namespace EverCraft
{
    class Enemy
    {
        public int hitPoints = 3;
        public int armorClass = 11;
        public int attackDamage = 0;
        public int attackRoll = 0;

        public string Name
        { get; set; }
    }
}
