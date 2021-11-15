using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EverTests
{
    [TestClass]
    public class CharacterAbilitiesTest
    {
        // Abilities are Strength, Dexterity, Constitution, Wisdom, Intelligence, Charisma
        // Abilities range from 1 to 20 and default to 10
        // Abilities have modifiers according to the following table

        [TestMethod]
        public void TestAbilities()
        {
           var character = new Character("Abel");
           
        }

    }
}