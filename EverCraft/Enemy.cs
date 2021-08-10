using System;
using System.Collections.Generic;
using System.Text;

namespace EverCraft
{
    class Enemy
    {
        public int hitPoints = 3;
        public int armorClass = 11;

        public string Name
        { get; set; }

        public static void SpawnOgre()
        {
            var enemy = new Enemy();
            enemy.Name = "Ogre";
            enemy.hitPoints = 6;
            enemy.armorClass = 8;
        }
    }
}
