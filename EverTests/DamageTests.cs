using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EverTests
{
    [TestClass]
    public class AttackDamageTests
    {
        private Character defender;
        private Character attacker;

        [TestInitialize]
        public void SetupCharacters()
        {
            defender = new Character("Defender");
            attacker = new Character("Attacker");
        }

        [TestMethod]
        public void SuccessfulAttachDeals1PointOfDamageToDefender()
        {
            var diceRoll = 19;

            attacker.Attack(defender, diceRoll);

            Assert.AreEqual(Character.Defaults.hitPoints - 1,  defender.hitPoints);
        }

        [TestMethod]
        public void CriticalHitDealsDoubleDamage()
        {
            var diceRoll = 20;

            attacker.Attack(defender, diceRoll);

            Assert.AreEqual(Character.Defaults.hitPoints - 2, defender.hitPoints);
        }

        [TestMethod]
        public void DefenderDiesWhenHitPointsGoesToZero()
        {
            defender.hitPoints = 1;
            var diceRoll = Character.Defaults.armor +1;

            attacker.Attack(defender, diceRoll);

            Assert.IsTrue(defender.IsDead);
        }

        [TestMethod]
        public void DefenderDiesWhenHitPointsGoesBelowZero()
        {
            defender.hitPoints = 1;
            var diceRoll = 20;

            attacker.Attack(defender, diceRoll);

            Assert.IsTrue(defender.IsDead);
        }
    }
}