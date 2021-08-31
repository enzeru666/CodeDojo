using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace EverCraft
{
    interface IEnemy
    {
        int HitPoints { get; set; }
        int ArmorClass { get; set; }
        string Name { get; set; }
    }

    class Ogre : IEnemy
    {
    }
