using System;

namespace EverCraft
{
    class EverCraft
    {
        static void Main(string[] args)
        {
            Character character = new Character();

            Console.WriteLine(character.hitPoints);
            Console.WriteLine(character.armorClass);
        }
    }
}
