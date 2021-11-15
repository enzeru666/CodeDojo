using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EverTests
{
    [TestClass]
    public class AttackDamageTests
    {
        [TestMethod]
        public void SuccessfulAttachDeals1PointOfDamageToDefender()
        {
            var defender = new Character("Defender");
            var attacker = new Character("Attacker");

            var diceRoll = 19;

            attacker.Attack(defender, diceRoll);

            Assert.AreEqual(Character.Defaults.hitPoints - 1,  defender.hitPoints);
        }

        [TestMethod]
        public void CriticalHitDealsDoubleDamage()
        {
            var defender = new Character("Defender");
            var attacker = new Character("Attacker");

            var diceRoll = 20;

            attacker.Attack(defender, diceRoll);

            Assert.AreEqual(Character.Defaults.hitPoints - 2, defender.hitPoints);
        }

        [TestMethod]
        public void DefenderDiesWhenHitPointsGoesToZero()
        {
            var defender = new Character("Defender"){hitPoints = 1};
            var attacker = new Character("Attacker");

            var diceRoll = Character.Defaults.armor +1;

            attacker.Attack(defender, diceRoll);

            Assert.IsTrue(defender.IsDead);
        }

        [TestMethod]
        public void DefenderDiesWhenHitPointsGoesBelowZero()
        {
            var defender = new Character("Defender") { hitPoints = 1 };
            var attacker = new Character("Attacker");

            var diceRoll = 20;

            attacker.Attack(defender, diceRoll);

            Assert.IsTrue(defender.IsDead);
        }
    }
}