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

            var hitResult = defender.DefendAgainst(diceRoll);

            Assert.AreEqual(HitType.Success, hitResult);
        }

        [TestMethod]
        public void IfAttackRollIsLowerThanArmorClassTheAttackFailed()
        {
            var defender = new Character("Defender");
            var diceRoll = Character.Defaults.armor - 1;

            var hitResult = defender.DefendAgainst(diceRoll);

            Assert.AreEqual(HitType.Miss, hitResult);
        }

        [TestMethod]
        public void DiceRollOf20AlwaysHitsRegardlessOfArmour()
        {
            var defender = new Character("Defender")
            {
                armorClass = 21,
            };

            var diceRoll = 20;

            var hitResult = defender.DefendAgainst(diceRoll);

            Assert.AreEqual(HitType.Critical, hitResult);
        }
    }
}