using System;
using System.Linq;
using Microsoft.VisualBasic;

namespace EverCraft
{
    class EverCraft
    {
        public static string[] EnemyNames = {"Kobold", "black harpy", "green icky thing", "cave spider"};
        
        static void Main(string[] args)
        {
            var playerCharacter = GetPlayerCharacter();

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
                    var enemy = GetAnEnemy();
                    Console.WriteLine("You face a " + enemy.Name + "! It will surely destroy you");
                    Console.ReadLine();
                    while (!enemy.IsDead)
                    {
                        var diceRoll = RollD20();
                        var attackResult = playerCharacter.Attack(enemy, diceRoll);
                        if (attackResult == HitType.Critical)
                        {
                            Console.WriteLine("You critically wound the " + enemy.Name + "! maybe you will yet live..");
                        }
                        else if (attackResult == HitType.Success)
                        {
                            Console.WriteLine("You swipe at the " + enemy.Name + ", opening a gaping wound! the creature grows weaker");
                        }
                        else if (attackResult == HitType.Miss)
                        {
                            Console.WriteLine("You wave your weapon feebly in the general direction of the " + enemy.Name + ", it releases a long hollow laugh");
                        }
                        Console.ReadLine();
                    }

                    Console.WriteLine("The " + enemy.Name + "stumbles before falling awkwardly to the floor, dead. you live to fight another day!");

                    return true;
                }
                else if (result == "2")
                {
                    Console.WriteLine("Your HP is: " +playerCharacter.hitPoints);
                    Console.WriteLine("Your AC is: " +playerCharacter.armorClass);
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

        private static int RollD20()
        {
            return new Random().Next(1, 20);
        }

        private static Character GetAnEnemy()
        {
            var randomEnemyName = EnemyNames.OrderBy(x => Guid.NewGuid()).First();
            return new Character(randomEnemyName);
        }

        private static Character GetPlayerCharacter()
        {
            Console.WriteLine("enter your character name:");
            var characterName = Console.ReadLine();
            return new Character(characterName);
        }
    }
}
