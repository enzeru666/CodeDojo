using EverCraft;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EverTests
{
    [TestClass]
    public class ActionTests
    {
        [TestMethod]
        public void IfAttackRollIsHigherThanArmorClassTheAttackIsSuccessful()
        {
            var defender = new Character("Defender");
            var diceRoll = Character.Defaults.armor + 1;

            var successfulHit = defender.DefendAgainst(diceRoll);

            Assert.IsTrue(successfulHit);
        }

        [TestMethod]
        public void IfAttackRollIsLowerThanArmorClassTheAttackFailed()
        {
            var defender = new Character("Defender");
            var diceRoll = Character.Defaults.armor - 1;

            var successfulHit = defender.DefendAgainst(diceRoll);

            Assert.IsFalse(successfulHit);
        }

        [TestMethod]
        public void DiceRollOf20AlwaysHitsRegardlessOfArmour()
        {
            var defender = new Character("Defender")
            {
                armorClass = 21,
            };

            var diceRoll = 20;

            var successfulHit = defender.DefendAgainst(diceRoll);

            Assert.IsTrue(successfulHit);
        }
    }
}