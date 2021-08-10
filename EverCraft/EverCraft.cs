using System;

namespace EverCraft
{
    class EverCraft
    {
        static void Main(string[] args)
        {
            var character = new Character();
            var enemy = new Enemy();

            var displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }

            bool MainMenu()
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Challenge an enemy");
                Console.WriteLine("2) Show your HP and AC");
                Console.WriteLine("3) Exit");
                string result = Console.ReadLine();
                if (result == "1")
                {
                    var combat = true;

                    Enemy.SpawnOgre();
                    Console.WriteLine("You face a "+enemy.Name+"! It will surely destroy you");
                    Console.ReadLine();

                    Console.WriteLine();
                    return true;
                }
                else if (result == "2")
                {
                    Console.WriteLine("Your HP is: " +character.hitPoints);
                    Console.WriteLine("Your AC is: " +character.armorClass);
                    Console.ReadLine();
                    return true;
                }
                else if (result == "3")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
