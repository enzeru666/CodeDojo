using System;

namespace EverCraft
{
    class EverCraft
    {
        static void Main(string[] args)
        {
            Character character = new Character();

            Console.WriteLine($"My HP: "+character.hitPoints);
            Console.WriteLine($"My AC: "+character.armorClass);
            Console.ReadLine();
        }
    }
}
